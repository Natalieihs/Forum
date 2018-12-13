using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Models;

namespace Demo.Services
{
    public class OnlineUsersService : DbContext, IOnlineUsersService
    {
        private readonly IHttpContextAccessor _httpcontext;
        public OnlineUsersService(IHttpContextAccessor httpContext)
        {
            _httpcontext = httpContext;
        }
        public async Task<bool> AddOnlineUser(bma_onlineusers onlineuser)
        {
         return  await  db.Insertable(new bma_onlineusers
            {
                ip = onlineuser.ip,
                nickname = onlineuser.nickname,
                olid = 0,
                regionid = 0,
                sid = onlineuser.sid,
                uid = 0,
                updatetime = DateTime.Now
            }).ExecuteCommandAsync()>0;
        }

        public async Task<bool> GetOnlineusersBySid(string sid)
        {
           var users =await db.Queryable<bma_onlineusers>().Where(c => c.sid == sid).SingleAsync();
            return users == null;
        }
    }
}
