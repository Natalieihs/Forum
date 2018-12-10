using Forum.Core;
using Forum.Services.DtoModel;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Services.Interfaces
{
    public interface ISysUserInfoService: IBaseServer<SysUserInfo>
    {
        Task<ApiResult<SysUserInfo>> LoginAsync(SysAdminLogin parm);
    }
}
