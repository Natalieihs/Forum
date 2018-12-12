using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Services;
using Microsoft.AspNetCore.Authorization;
using Demo.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Demo.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IUserServices _userServices;
        private readonly IHttpContextAccessor _httpContext;
        public AccountController(IUserServices userServices,IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
            _userServices = userServices;
        }
        [Route("/account/login")]
        [HttpGet,AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost,AllowAnonymous,ValidateAntiForgeryToken]
        public async Task<IActionResult>Login(string returnUrl, LoginViewModel model)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid&& _userServices.ValidateUser(model.UserName,model.Password))
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, model.UserName));
                var principle = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties { IsPersistent = model.RememberMe };
               
                
                await HttpContext.SignInAsync(principle, properties);
                HttpContext.User = principle;
                return LocalRedirect(returnUrl ?? "/");
            }
            ModelState.AddModelError(string.Empty, "Username or password is invalid.");
            return View("Login", model);
        }
    }
}