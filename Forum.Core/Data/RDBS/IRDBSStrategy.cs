using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Forum.Core.Data.RDBS
{
    public partial interface IRDBSStrategy
    {
        /// <summary>
        /// 获得数据库提供程序工厂
        /// </summary>
        DbProviderFactory GetDbProviderFactory();

        /// <summary>
        /// 运行SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        string RunSql(string sql);
    }
}
