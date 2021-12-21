using Durur.Erp.Api.TokenModels;
using Durur.Modules.Generic.DataAccess;
using Durur.Modules.Generic.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Durur.Erp.Api.Helpers;
using System.Text.RegularExpressions;

namespace Durur.Erp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ErpGenericDbContext context;
        private readonly IConfiguration configuration;
        private readonly GenericHelper genericHelper;

        public LoginController(ErpGenericDbContext context, IConfiguration configuration, GenericHelper genericHelper)
        {
            this.context = context;
            this.configuration = configuration;
            this.genericHelper = genericHelper;
        }

        [HttpPost("[action]")]
        public async Task<bool> Create([FromBody] User user)
        {
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            user.EmailConfirmed = false;
            user.PhoneNumberConfirmed = false;
            user.TwoFactorEnabled = false;
            user.PasswordHash = genericHelper.GetHashSha256(user.PasswordHash);
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return true;
        }



        [HttpPost("[action]")]
        public async Task<Token> Login([FromBody] UserLogin userLogin)
        {
            User user = null;
            //Regex mailRegex = new Regex(@"^\\w + ([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w{2,}([-.]\\w+)*$");
            if (userLogin.UserCredential.Contains("@"))
                user = await context.Users.FirstOrDefaultAsync(w => w.NormalizedEmail == userLogin.UserCredential.ToUpper() && w.PasswordHash == genericHelper.GetHashSha256(userLogin.Password));
            else
                user = await context.Users.FirstOrDefaultAsync(w => w.NormalizedUserName == userLogin.UserCredential.ToUpper() && w.PasswordHash == genericHelper.GetHashSha256(userLogin.Password));
            if (user != null && user.IsActive)
            {
                return await genericHelper.CreateToken(user, context, configuration);
            }
            return null;
        }


        [HttpPost("[action]")]
        public async Task<Token> RefreshTokenLogin([FromForm] string refreshToken)
        {
            User user = await context.Users.FirstOrDefaultAsync(w => w.RefreshToken == refreshToken);
            if (user != null && user.RefreshTokenEndTime > DateTime.UtcNow)
            {
                return await genericHelper.CreateToken(user, context, configuration);
            }
            return null;
        }


    }
}
