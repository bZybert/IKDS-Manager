using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IKDDS_Manager.Models;
using IKDDS_Manager.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IKDDS_Manager.Controllers
{
    public class SummaryController : Controller
    {
        public readonly EFCContext _context;

        public SummaryController()
        {
            _context = new EFCContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IActionResult MainTable()
        {
            var invest = _context.IKDDSModels.ToList();
            

            var viewModel = new MainTableViewModel
            {
                IKDDSModels = invest,
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var toEdit = _context.IKDDSModels.SingleOrDefault(x => x.Id == id);

            return View(toEdit);
        }


        public IActionResult Delete(int id)
        {
            var toDel = _context.IKDDSModels.Single(x => x.Id == id);
            _context.IKDDSModels.Remove(toDel);
            _context.SaveChanges();

            return View("MainTable");
        }
    }
}