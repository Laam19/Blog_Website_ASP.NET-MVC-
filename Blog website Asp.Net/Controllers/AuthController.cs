using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Blog_website_Asp.Net.ViewModels;

namespace Blog_website_Asp.Net.Controllers
{
    public class AuthController:Controller
    {
        private SignInManager<IdentityUser> _signInManager;
        public AuthController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LogInViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Login(LogInViewModel vm)
        {
            var result= await _signInManager.PasswordSignInAsync(vm.UserName, vm.password, false, false);
            return RedirectToAction("index", "Panel");
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "Home");
        }
    }
}
