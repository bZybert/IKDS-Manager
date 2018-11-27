using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IKDS_Manager.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public string Email { get; set; }
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword

        [Required]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Powtórz hasło")]
        public string RepeatPassword { get; set; }

        public bool RememberMe { get; set; }
    }
}
