using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.httpContext = HttpContext;
            return View();
        }
    }
}