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
        protected SignInManager<IdentityUser> SignInManager { get; }

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser(viewModel.Login) { Email = viewModel.Login };
                var result = await UserManager.CreateAsync(user, viewModel.Password);
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

        public IActionResult Login()
        {
            /*
            return View(new RegisterViewModel()
            {
                ReturnUrl = returnUrl
            });*/
            return View();
              
            
        }

        [HttpPost]
        public async Task<IActionResult> Login(RegisterViewModel viewModel)
        {
            /*
            if (ModelState.IsValid)
            {
                var result = await SignInManager.PasswordSignInAsync(viewModel.Login,
                viewModel.Password, viewModel.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Nie można się zalogować!");
                }
            }
            return View(viewModel);*/

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var user = await UserManager.FindByNameAsync(viewModel.Login);
            if (user != null)
            {
                var result = await SignInManager.PasswordSignInAsync(viewModel.Login, viewModel.Password, false, false);
                if (result.Succeeded)
                {
                   // if (string.IsNullOrEmpty(viewModel.ReturnUrl))
                        return RedirectToAction("Index", "Home");

                   // return Redirect(viewModel.ReturnUrl);
                }
            }

            ModelState.AddModelError("", "Nie można się zalogować!");
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}