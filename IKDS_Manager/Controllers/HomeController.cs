using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IKDS_Manager.Models;
using IKDDS_Manager.Models;
using IKDDS_Manager.ViewModels;

namespace IKDS_Manager.Controllers
{
    public class HomeController : Controller
    {
        public readonly EFCContext _context;

        public HomeController()
        {
            _context = new EFCContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

       
        public IActionResult Index()
        {
           

            return View();
        }
        [HttpGet]
        public IActionResult Reminder()
        {
            var today = DateTime.Now.AddDays(6);
            var reminder = _context.IKDDSModels.ToList();
            

            if (reminder != null)
            {
                
                var viewModel = new MainTableViewModel
                {
                     IKDDSModels = reminder,
                };
                return View(viewModel);
            }
            
            return View("Index");
        }

        
    }
}
