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
            var closeToEnd = _context.IKDDSModels.ToList();
            var viewModel = new List<IKDDSModel>();
            foreach(var el in closeToEnd)
            {
                TimeSpan result = DateTime.Now - el.FinalData;
                
               
            }

            return View(viewModel);
        }

        
    }
}
