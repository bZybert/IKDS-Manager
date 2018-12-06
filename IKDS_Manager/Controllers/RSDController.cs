using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IKDDS_Manager.Models;
using IKDDS_Manager.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IKDS_Manager.Controllers
{
    [Authorize]
    public class RSDController : Controller
    {
        public readonly EFCContext _context;

        public RSDController()
        {
            _context = new EFCContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IActionResult RsdTable()
        {
            var rsd = _context.IKDDSModels.ToList();
            var viewModel = new MainTableViewModel
            {
                IKDDSModels = rsd,
            };
            return View(viewModel);

        }
    }
}
