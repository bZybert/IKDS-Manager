using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IKDS_Manager.Controllers
{
    public class RSDController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}