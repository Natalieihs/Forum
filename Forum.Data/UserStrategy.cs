using Forum.Core.Data.RDBS;
using Forum.Core.Domain;
using Forum.RDBSStrategy.SqlServer.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
namespace Forum.Data
{
    public partial class RDBSStrategy : DbContext,IRDBSStrategy
    {
        /// <summary>
        /// 创建在线用户
        /// </summary>
        /// <param name="onlineUserInfo"></param>
        /// <returns></returns>
        public  async Task<int> CreateOnlineUser(OnlineUserInfo onlineUserInfo)
        {
           return await db.Insertable(onlineUserInfo).AS("bma_onlineusers").ExecuteCommandAsync();
        }
        public void DeleteExpiredOnlineUser(int onlineUserExpire)
        {
            throw new NotImplementedException();
        }

        public void DeleteOnlineUserBySid(string sid)
        {
            throw new NotImplementedException();
        }

        public DbProviderFactory GetDbProviderFactory()
        {
            throw new NotImplementedException();
        }

        public IDataReader GetOnlineUserBySid(string sid)
        {
            throw new NotImplementedException();
        }

        public int GetOnlineUserCount(int userType)
        {
            throw new NotImplementedException();
        }

        public int GetOnlineUserCount(int locationType, int locationId)
        {
            throw new NotImplementedException();
        }

        public IDataReader GetOnlineUserList(int pageSize, int pageNumber, int locationType, int locationId)
        {
            throw new NotImplementedException();
        }

        public List<bma_onlineusers> GetOnlineusers()
        {
            return db.Queryable<bma_onlineusers>().AS("bma_onlineusers").ToList();
        }

        public async Task<List<bma_news>> Get_News()
        {
            return await db.Queryable<bma_news>().AS("bma_news").ToListAsync();
        }

        public void ResetOnlineUserTable()
        {
            throw new NotImplementedException();
        }

        public string RunSql(string sql)
        {
            throw new NotImplementedException();
        }

        public void UpdateOnlineUserIP(int olId, string ip)
        {
            throw new NotImplementedException();
        }

        public void UpdateOnlineUserUid(int olId, int uid)
        {
            throw new NotImplementedException();
        }
    }
}
