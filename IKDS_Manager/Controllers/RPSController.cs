﻿using System;
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
    public class RPSController : Controller
    {
        public readonly EFCContext _context;

        public RPSController()
        {
            _context = new EFCContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IActionResult RpsTable()
        {
            var rps = _context.IKDDSModels.ToList();
            var viewModel = new MainTableViewModel
            {
                IKDDSModels = rps,
            };
            return View(viewModel);
           
        }
    }
}