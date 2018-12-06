using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IKDDS_Manager.Controllers
{
    public class AuthController : Controller
    {
        protected UserManager<IdentityUser> UserManager { get; }
        protected RoleManager<IdentityRole> RoleManager { get; }
        public AuthController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            RoleManager = roleManager;
            UserManager = userManager;
        }

        //tworzenie roli
        //var ir = new IdentityRole(roleName);
        // await RoleManager.CreateAsync(ir);

        //pobieranie danych o użytkowniku
        public async Task<IActionResult> GetUser()
        {
            IdentityUser user = await UserManager.GetUserAsync(User);
            return View(user);
        }

        //dodawanie użytkownika do roli
        public async Task<IActionResult> AddUserToRole()
        {
            IdentityUser user = await UserManager.GetUserAsync(User);
            await UserManager.AddToRoleAsync(user, "Admin");
            return RedirectToAction("Index", "Home");
        }
    }
}