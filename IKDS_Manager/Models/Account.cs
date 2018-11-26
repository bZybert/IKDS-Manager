using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IKDDS_Manager.Models
{
    public class Account: IdentityUser<string>
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }

        public string Email { get; set; }

        [Required]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Powtórz hasło")]
        public string RepeatPassword { get; set; }
    }
}
