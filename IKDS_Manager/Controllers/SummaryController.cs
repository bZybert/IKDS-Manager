using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IKDDS_Manager.Controllers
{
    public class SummaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MainTable()
        {
            return View();
        }
    }
}