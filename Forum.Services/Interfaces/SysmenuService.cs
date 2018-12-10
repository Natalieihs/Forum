using Forum.Common;
using Forum.Core;
using Forum.Services.DtoModel;
using Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;
namespace Forum.Services.Interfaces
{
    public class SysmenuService : DbContext, ISysmenuService
    {
        public Task<ApiResult<string>> AddAsync(sysmenu parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> AddListAsync(List<sysmenu> parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> DeleteAsync(string parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> DeleteAsync(Expression<Func<sysmenu, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> DeleteAsync(Expression<Func<sysmenu, sysmenu>> columns, Expression<Func<sysmenu, bool>> where)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResult<List<sysmenu>>> GetListAsync(Expression<Func<sysmenu, bool>> where, Expression<Func<sysmenu, object>> order, DbOrderEnum orderEnum)
        {
            throw new NotImplementedException();
        }

        private void ChildModule(List<sysmenu> list, List<sysmenu> newlist, string parentId)
        {
            if (list==null)
            {
                return;
            }
            var result = list.Where(c => c.ParentGuid == parentId).OrderBy(c => c.Layer).ThenBy(c => c.Sort).ToList();
            if (!result.Any()) return;
            for (int i = 0; i < result.Count; i++)
            {
                newlist.Add(result[i]);
                ChildModule(list, newlist, result[i].Guid);
            }
        }
        public Task<ApiResult<List<sysmenu>>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<sysmenu>> GetModelAsync(string parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<sysmenu>> GetModelAsync(Expression<Func<sysmenu, bool>> where)
        {
            throw new NotImplementedException();
        }

        public new  async Task<ApiResult<Page<sysmenu>>> GetPagesAsync(PageParm parm)
        {
            var res = new ApiResult<Page<sysmenu>>();
            try
            {
                Task<Page<sysmenu>> query = db.Queryable<sysmenu>()
                        .WhereIF(!string.IsNullOrEmpty(parm.key), m => m.ParentGuidList.Contains(parm.key))
                        .OrderBy(m => m.Sort).ToPageAsync(parm.page, parm.limit);
                res.success = true;
                res.message = "获取成功";
                var result = new List<sysmenu>();
                ChildModule(query.Result.Items, result, null);
                query.Result.Items = result;
                res.data = await query;
            }
            catch (Exception ex)
            {
                res.message = ApiEnum.Error.GetEnumText() + ex.Message;
                res.statusCode = (int)ApiEnum.Error;
            }
            return await Task.Run(() => res);
        }

        public Task<ApiResult<Page<sysmenu>>> GetPagesAsync(PageParm parm, Expression<Func<sysmenu, bool>> where, Expression<Func<sysmenu, object>> order, DbOrderEnum orderEnum)
        {
            throw new NotImplementedException();
        }

        public Task<sysmenu> GetSysmenus()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> UpdateAsync(sysmenu parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> UpdateAsync(Expression<Func<sysmenu, sysmenu>> columns, Expression<Func<sysmenu, bool>> where)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 获得一条数据
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public async Task<ApiResult<sysmenu>> GetByGuidAsync(string parm)
        {
            var model = db.Queryable<sysmenu>().Where(c => c.Guid == parm).First();
            var res = new ApiResult<sysmenu>
            {
                statusCode = 200
            };
            var pmodel = db.Queryable<sysmenu>().OrderBy(c => c.Sort, SqlSugar.OrderByType.Desc).First();
            res.data = model ?? new sysmenu() { Sort = pmodel?.Sort + 1 ?? 1, Status = true };
            return await Task.Run(() => res);
        }
    }
}
