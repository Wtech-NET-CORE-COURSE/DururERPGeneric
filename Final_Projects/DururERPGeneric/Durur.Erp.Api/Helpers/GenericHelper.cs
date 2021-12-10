using Durur.Erp.Api.TokenModels;
using Durur.Modules.Generic.DataAccess;
using Durur.Modules.Generic.Entities.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Durur.Erp.Api.Helpers
{
    public class GenericHelper
    {
        public GenericHelper()
        {

        }
        public async Task<Token> CreateToken(User user,ErpGenericDbContext context,IConfiguration configuration)
        {
            //User için token üretiliyor
            TokenHandler tokenHandler = new TokenHandler(configuration);
            Token token = tokenHandler.CreateAccessToken();
            //Refresh token kullanıcı tablosuna işleniyor
            user.RefreshToken = token.RefreshToken;
            user.RefreshTokenEndTime = token.Expiration.AddMinutes(5);
            await context.SaveChangesAsync();
            return token;
        }
    }
}
