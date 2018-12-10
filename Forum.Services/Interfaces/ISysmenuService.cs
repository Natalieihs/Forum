using Forum.Core;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Services.Interfaces
{
    public interface ISysmenuService: IBaseServer<sysmenu>
    {
        Task<sysmenu> GetSysmenus();
        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<sysmenu>> GetByGuidAsync(string parm);
    }
}
