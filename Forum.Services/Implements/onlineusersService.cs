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
    public class onlineusersService: DbContext, IonlineusersService
    {
        public Task<ApiResult<string>> AddAsync(bma_onlineusers parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> AddListAsync(List<bma_onlineusers> parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> DeleteAsync(string parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> DeleteAsync(Expression<Func<bma_onlineusers, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> DeleteAsync(Expression<Func<bma_onlineusers, bma_onlineusers>> columns, Expression<Func<bma_onlineusers, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<List<bma_onlineusers>>> GetListAsync(Expression<Func<bma_onlineusers, bool>> where, Expression<Func<bma_onlineusers, object>> order, DbOrderEnum orderEnum)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<List<bma_onlineusers>>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bma_onlineusers>> GetModelAsync(string parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bma_onlineusers>> GetModelAsync(Expression<Func<bma_onlineusers, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<Page<bma_onlineusers>>> GetPagesAsync(PageParm parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<Page<bma_onlineusers>>> GetPagesAsync(PageParm parm, Expression<Func<bma_onlineusers, bool>> where, Expression<Func<bma_onlineusers, object>> order, DbOrderEnum orderEnum)
        {
            throw new NotImplementedException();
        }

        public async Task<List<bma_onlineusers>> Get_Onlineusers()
        {
            return await db.Queryable<bma_onlineusers>().ToListAsync();
        }

        public Task<ApiResult<string>> UpdateAsync(bma_onlineusers parm)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<string>> UpdateAsync(Expression<Func<bma_onlineusers, bma_onlineusers>> columns, Expression<Func<bma_onlineusers, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}
