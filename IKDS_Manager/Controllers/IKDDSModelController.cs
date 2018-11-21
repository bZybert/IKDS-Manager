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
                return View("New");

            }
            if (ikddsmodel.RpsNumber != null)
            {
                ikddsmodel.FinalData = ikddsmodel.EntryData.AddDays(30);
                //ikddsmodel.InvestigationType.Type;
            }
            else if (ikddsmodel.RsdNumber != null)
            {
                ikddsmodel.FinalData = ikddsmodel.EntryData.AddDays(60);
               // ikddsmodel.InvestigationType.Type = "RSD";
            }
            else if ((ikddsmodel.RpsNumber != null) && (ikddsmodel.RsdNumber != null))
            {
                ikddsmodel.FinalData = ikddsmodel.EntryData.AddDays(60);
                //ikddsmodel.InvestigationType.Type = "RPS/RSD";
            }

            _context.IKDDSModels.Add(ikddsmodel);
            _context.SaveChanges();
            return RedirectToAction("MainTable", "Summary");
        }

    }
}