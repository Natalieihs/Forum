using Forum.Common;
using Forum.Core;
using Forum.Services.DtoModel;
using Forum.Services.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Services.Implements
{
    public class SysUserInfoService :BaseServer<SysUserInfo>, ISysUserInfoService
    {
        public Task<ApiResult<string>> AddAsync(SysUserInfo parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> AddListAsync(List<SysUserInfo> parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> DeleteAsync(string parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> DeleteAsync(Expression<Func<SysUserInfo, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> DeleteAsync(Expression<Func<SysUserInfo, SysUserInfo>> columns, Expression<Func<SysUserInfo, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<List<SysUserInfo>>> GetListAsync(Expression<Func<SysUserInfo, bool>> where, Expression<Func<SysUserInfo, object>> order, DbOrderEnum orderEnum)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<List<SysUserInfo>>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SysUserInfo>> GetModelAsync(string parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SysUserInfo>> GetModelAsync(Expression<Func<SysUserInfo, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<Page<SysUserInfo>>> GetPagesAsync(PageParm parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<Page<SysUserInfo>>> GetPagesAsync(PageParm parm, Expression<Func<SysUserInfo, bool>> where, Expression<Func<SysUserInfo, object>> order, DbOrderEnum orderEnum)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 用户登录实现
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<SysUserInfo>> LoginAsync(SysAdminLogin parm)
        {
            var res = new ApiResult<SysUserInfo>();
            parm.password = DES3Encrypt.EncryptString(parm.password);
            var model = db.Queryable<SysUserInfo>()
                .Where(c => c.loginName == parm.loginname).First();
            if (model!=null)
            {
                if (model.loginPWD.Equals(parm.password))
                {
                    //修改登录时间

                    //保存操作日志
                    res.success = true;
                    res.message = "获取成功";
                    res.data = model;
                }
                else
                {
                    res.success = false;
                    res.message = "密码错误";
                    res.statusCode = (int)ApiEnum.Error;
                }
            }
            else
            {
                res.success = false;
                res.statusCode = (int)ApiEnum.Error;
                res.message = "账号错误~";
            }
            return await Task.Run(() => res);
        }

        public Task<ApiResult<string>> UpdateAsync(SysUserInfo parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> UpdateAsync(Expression<Func<SysUserInfo, SysUserInfo>> columns, Expression<Func<SysUserInfo, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}
