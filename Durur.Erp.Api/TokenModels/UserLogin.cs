using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Durur.Erp.Api.TokenModels
{
    public class UserLogin
    {
        public string UserCredential { get; set; }

        public string Password { get; set; }
    }
}
