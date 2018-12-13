using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class Help
    {
        private  readonly IHttpContextAccessor _httpcontext;

        public Help(IHttpContextAccessor httpContext)
        {
            _httpcontext = httpContext;
        }
        public  string GenerateSid()
        {
            long i = 1;
            byte[] byteArray = Guid.NewGuid().ToByteArray();
            foreach (byte b in byteArray)
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        public  string GetCookies(string key)
        {
            _httpcontext.HttpContext.Request.Cookies.TryGetValue(key, out string value);
            if (string.IsNullOrEmpty(value))
                value = string.Empty;
            return value;
        }
        public void SetCookies(string key, string value, int minutes = 30)
        {
            _httpcontext.HttpContext.Response.Cookies.Append(key, value, new CookieOptions
            {
                Expires = DateTime.Now.AddMinutes(minutes)
            });
        }
    }
}
