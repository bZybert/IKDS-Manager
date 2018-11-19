using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IKDDS_Manager.Models;
using IKDDS_Manager.ViewModels;
using IKDS_Manager.Models;
using Microsoft.AspNetCore.Mvc;

namespace IKDS_Manager.Controllers
{
    public class IKDDSModelController : Controller
    {
        public readonly EFCContext _context;

        public IKDDSModelController()
        {
            _context = new EFCContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IActionResult New()
        {
            
            var invTypes = _context.InvestigationType.ToList();
            //var invInit = _context.InvestigationInitiateTypes.ToList();

            var viewModel = new IKDDSFormViewModel()
            {
                IKDDSModel = new IKDDSModel(),
                InvestigationType = invTypes,
                //investigationInitiateTypes = invInit
            }; 
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult IKDDSForm(IKDDSModel ikddsmodel)
        {
            if (!ModelState.IsValid)
            {
                var invTypes = _context.InvestigationType.ToList();
                //var invInit = _context.InvestigationInitiateTypes.ToList();

                var viewModel = new IKDDSFormViewModel()
                {
                    IKDDSModel = new IKDDSModel(),
                    InvestigationType = invTypes,
                    //investigationInitiateTypes = invInit
                };
                return View("New" ,viewModel);
            }

            _context.IKDDSModels.Add(ikddsmodel);
            _context.SaveChanges();
            return View("New");
        }

    }
}