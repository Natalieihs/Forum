using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Extensions
{
    public class JwtAuthorizationFilter
    {

        private readonly RequestDelegate _next;
        public JwtAuthorizationFilter(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            if (!httpContext.Request.Headers.ContainsKey("Authorization"))
            {
                return _next(httpContext);
            }

            var tokenHeader = httpContext.Request.Headers["Authorization"];
            tokenHeader = tokenHeader.ToString().Substring("Bearer ".Length).Trim();
            TokenModel tm = JwtHelper.SerializeJWT(tokenHeader);
            //授权
            var claimList = new List<Claim>();
            var claim = new Claim(ClaimTypes.Role, tm.Role);
            claimList.Add(claim);
            var identity = new ClaimsIdentity(claimList);
            var principal = new ClaimsPrincipal(identity);
            httpContext.User = principal;
            return _next(httpContext);
        }
    }
}
