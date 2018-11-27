using IKDDS_Manager.Models;
using IKDS_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IKDDS_Manager.ViewModels
{
    public class RegisterViewModel
    {
        public User User { get; set; }
        public string ReturnUrl { get; set; }
    }
}
