using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Durur.Modules.Generic.Entities.Model
{
    public class User : DateLogEntity
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_ID { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(64)]
        [Required]
        public string Password { get; set; }

        [StringLength(50)]
        [Required]
        public string Mail { get; set; }

        public bool IsActive { get; set; }

        public string RefreshToken { get; set; }

        public DateTime? RefreshTokenEndTime { get; set; }

        public Customer Customer { get; set; }

    }
}
