using Demo.Services;
using Microsoft.AspNetCore.Http;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSRedis.NetCore;
using Newtonsoft.Json;

namespace Demo.Middleware
{
    public class OnlineFilter
    {
        private const string key = "bma";
        private readonly RequestDelegate _next;
        private readonly IOnlineUsersService _onlineUsers;
        private readonly IHttpContextAccessor _httpcontext;

        private readonly RedisClient _client;
        public OnlineFilter(RequestDelegate next, IOnlineUsersService onlineUsersService,  IHttpContextAccessor httpcontext)
        {
            _next = next;
            _onlineUsers = onlineUsersService;
            _httpcontext = httpcontext;
            _client = new RedisClient("127.0.0.1", 6379);
        }

        public async Task Invoke(HttpContext context)
        {
            bool IsAvailable = context.Session.IsAvailable;
           
           // await context.Response.WriteAsync("==========================IsAvailable===========" + IsAvailable);
            string sessionid = context.Session.Id;
            Help help = new Help(_httpcontext);
            if (help.GetCookies(key).Length==0)
            {
                help.SetCookies(key, help.GenerateSid());
                if (_client.Get(key)==null)
                {
                    OnlineUser online = new OnlineUser { OnlineTime = DateTime.Now, NickName = "游客" };
                    _client.Set(key,JsonConvert.SerializeObject(online) , TimeSpan.FromMinutes(1));
                }
                else
                {
                    OnlineUser online = JsonConvert.DeserializeObject<OnlineUser>(_client.Get(key));
                    if (online!=null)
                    {
                        DateTime now = DateTime.Now;//9:05
                        DateTime time = online.OnlineTime;//8:59
                        _client.Set(key, JsonConvert.SerializeObject(now), TimeSpan.FromMinutes(1));
                    }
                }
            }
            ;
            string sid = help.GetCookies(key);
            if (await _onlineUsers.GetOnlineusersBySid(sid))
            {
                await _onlineUsers.AddOnlineUser(new bma_onlineusers
                {
                    sid = sid,
                    nickname = "游客",
                    ip = context.Connection.LocalIpAddress.ToString()
                });
            }
          
            await Task.Run(() => { });
            await _next(context);
        }
    }

    public class OnlineUser
    {
        public DateTime OnlineTime { get; set; }

        public string NickName { get; set; }
    }
}
