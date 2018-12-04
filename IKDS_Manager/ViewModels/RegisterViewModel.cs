using IKDDS_Manager.Models;
using IKDS_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IKDDS_Manager.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło" )]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Hasła nie są takie same")]
        [Display(Name = "Powtórz hasło")]
        public string RepeatPassword { get; set; }

        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
