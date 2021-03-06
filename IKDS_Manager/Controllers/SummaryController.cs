﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IKDDS_Manager.Models;
using IKDDS_Manager.ViewModels;
using IKDS_Manager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IKDDS_Manager.Controllers
{
    [Authorize]
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
        [AllowAnonymous]
        public IActionResult MainTable()
        {
            var invest = _context.IKDDSModels.Include(x => x.InvestigationType).ToList();


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
        [HttpPost]
        public IActionResult Save(IKDDSModel ikddsmodel)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }

            var toUpdate = _context.IKDDSModels.SingleOrDefault(t=> t.Id == ikddsmodel.Id);


            toUpdate.OfficerName = ikddsmodel.OfficerName;
            toUpdate.RpsNumber = ikddsmodel.RpsNumber;
            toUpdate.RsdNumber = ikddsmodel.RsdNumber;
            toUpdate.EntryData = ikddsmodel.EntryData;
            toUpdate.FinalData = ikddsmodel.FinalData;
            toUpdate.FinalOfInvestigation = ikddsmodel.FinalOfInvestigation;
            toUpdate.IKDDS = ikddsmodel.IKDDS;
            toUpdate.OZDate = ikddsmodel.OZDate;
            toUpdate.ArticleNumber = ikddsmodel.ArticleNumber;
            toUpdate.RealEndDate = ikddsmodel.RealEndDate;

            _context.SaveChanges();
            var invest = _context.IKDDSModels.Include(x => x.InvestigationType).ToList();


            var viewModel = new MainTableViewModel
            {
                IKDDSModels = invest,
            };
            return View("MainTable", viewModel);
        }


        public IActionResult Delete(int id)
        {
            var toDel = _context.IKDDSModels.Single(x => x.Id == id);
            _context.IKDDSModels.Remove(toDel);
            _context.SaveChanges();

            return RedirectToAction("MainTable");
        }
    }
}