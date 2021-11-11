using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Municipality.Model;

namespace Municipality.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("/login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVm vm, string returnUrl)
        {
            var claims = new List<Claim>
            {
                new Claim("username", vm.UserName), new Claim(ClaimTypes.NameIdentifier, vm.UserName)
            };
            var claimsIdentity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            var claimsPrincipal=new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimsPrincipal);
            return RedirectToAction("Average", "Dashboard");
        }
    }
}
