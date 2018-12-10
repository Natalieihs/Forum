using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Common;
using Forum.Core;
using Forum.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Forum.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ISysUserInfoService _sysUserInfoService;
        public AccountController(ISysUserInfoService sysUserInfoService)
        {
            _sysUserInfoService = sysUserInfoService;
        }
        public List<string> RsaKey { get; set; }
        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.RsaKey = RsaKey;
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName,string password, string privateKey, string publicKey)
        {
            var apiRes = new ApiResult<SysUserInfo>();
            var token = "";
            //Ras解密密码
            var ras = new RSACrypt(privateKey, publicKey);
            var loginmodel = _sysUserInfoService.GetModelAsync(c => c.loginName == userName);
            if (loginmodel==null)
            {

            }
            return null;
        }
    }
}