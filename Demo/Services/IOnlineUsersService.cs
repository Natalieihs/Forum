using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
namespace Demo.Services
{
    public interface IOnlineUsersService
    {
        Task<bool> AddOnlineUser(bma_onlineusers onlineuser);

        Task<bool> GetOnlineusersBySid(string sid);
    }
}
