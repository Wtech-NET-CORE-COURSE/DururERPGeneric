using Durur.Modules.Generic.Entities.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Erp.Api.TokenModels
{
    public class TokenHandler
    {
        public IConfiguration Configuration { get; set; }

        public TokenHandler(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //Token üretecek method
        public Token CreateAccessToken()
        {
            Token token = new Token();
            //SecurityKey'in simetrik yansımasını alır
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"]));

            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);//Şifreli kimlik oluşturuluyor.

            token.Expiration = DateTime.UtcNow.AddMinutes(5);// token süresine 5 dk ekler

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                issuer: Configuration["Token:Issuer"],
                audience: Configuration["Token:Audience"],
                expires: token.Expiration,
                notBefore: DateTime.UtcNow,              //Token üretildikten sonra süre ne zaman devreye girsin.
                signingCredentials: signingCredentials
                );

            //Yeni bir access token üretir
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            token.AccessToken = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);
            //

            token.RefreshToken = CreateRefreshToken();
            return token;
        }

        public string CreateRefreshToken()
        {
            byte[] tokenArray = new byte[32];
            using RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(tokenArray);
            return Convert.ToBase64String(tokenArray);
        }
    }
}
