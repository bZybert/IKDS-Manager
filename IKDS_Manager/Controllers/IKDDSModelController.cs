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

        [HttpGet]
        public IActionResult IKDDSForm()
        {
            var invTypes = _context.InvestigationTypes.ToList();
            //var invInit = _context.InvestigationInitiateTypes.ToList();

            var viewModel = new IKDDSFormViewModel()
            {
                investigationTypes = invTypes,
                //investigationInitiateTypes = invInit
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult IKDDSForm(IKDDSModel ikddsmodel)
        {
            if (!ModelState.IsValid)
            {
                return Content(ikddsmodel.InvestigationInitiateTypeId.ToString());
            }

            return View();
        }

    }
}