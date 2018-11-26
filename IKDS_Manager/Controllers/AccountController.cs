using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IKDDS_Manager.ViewModels;
using IKDS_Manager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IKDDS_Manager.Controllers
{
    public class AccountController : Controller
    {
        protected UserManager<IdentityUser> UserManager { get; }

        public AccountController(UserManager<IdentityUser> userManager)
        {
            UserManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser(viewModel.Account.Login) { Email = viewModel.Account.Email };
                var result = await UserManager.CreateAsync(user, viewModel.Account.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(viewModel);
        }
    }
}