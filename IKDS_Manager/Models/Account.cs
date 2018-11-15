using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IKDDS_Manager.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}
