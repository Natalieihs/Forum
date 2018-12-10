using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Forum.Web.Models;
using Forum.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
namespace Forum.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IonlineusersService _ionlineusersService;
        public HomeController(IonlineusersService ionlineusersService)
        {
            _ionlineusersService = ionlineusersService;
        }
        public  async Task<IActionResult> Index()
        {
           var list= await _ionlineusersService.Get_Onlineusers();
            return Json(list);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
