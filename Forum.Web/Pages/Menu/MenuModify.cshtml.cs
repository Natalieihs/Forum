using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace Forum.Web.Pages.Menu
{
    public class MenuModify : PageModel
    {
        private readonly ISysmenuService _sysmenuService;
        public MenuModify(ISysmenuService sysmenuService)
        {
            _sysmenuService = sysmenuService;
        }
        [BindProperty]
        public sysmenu MenuModel { get; set; }
        public void OnGet(string guid)
        {
            MenuModel = _sysmenuService.GetByGuidAsync(guid).Result.data;
        }
    }
}