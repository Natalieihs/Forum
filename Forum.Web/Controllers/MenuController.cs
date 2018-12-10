using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Common;
using Forum.Services.DtoModel;
using Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly ISysmenuService _sysmenuService;
        
        public MenuController(ISysmenuService sysmenuService)
        {
            _sysmenuService = sysmenuService;
        }
        public async Task<JsonResult> GetPages(PageParm parm)
        {
            var res = await _sysmenuService.GetPagesAsync(parm);
            if (res.data.Items.Count > 0)
            {
                foreach (var item in res.data.Items)
                {
                    item.Name = Utils.LevelName(item.Name, item.Layer);
                }
            }
            return Json(new { code = 0, msg = "success", count = res.data.TotalItems, data = res.data.Items });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}