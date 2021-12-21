using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class User : IdentityUser<int>
    {
        [Required]
        public bool IsActive { get; set; }

        public string RefreshToken { get; set; }

        public DateTime? RefreshTokenEndTime { get; set; }

        public Customer Customer { get; set; }

    }
}
