using Forum.Extensions;
using Microsoft.Extensions.Configuration;
using Models;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Core
{
    public class DbContext
    {

        public DbContext()
        {
          //  IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
           // var config = builder.Build();
            db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = ConfigExtensions.Configuration["DbConnection:MySqlConnectionString"],
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            });
            //调式代码 用来打印SQL 
            db.Aop.OnLogExecuting = (sql, pars) =>
            {
                //Console.WriteLine(sql + "\r\n" +
                //    Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                //Console.WriteLine();
            };
        }

        public SqlSugarClient db;//用来处理事务多表查询和复杂的操作
        public DbSet<DbModel> GetDb<DbModel>() where DbModel : class, new()
        {
            return new DbSet<DbModel>(db);
        }
        public DbSet<bma_onlineusers> onlineUsers => new DbSet<bma_onlineusers>(db);
        /// <summary>
        /// 扩展ORM
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class DbSet<T> : SimpleClient<T> where T : class, new()
        {
            public DbSet(SqlSugarClient context) : base(context)
            {

            }
            /// <summary>
            /// 扩展假删除功能
            /// </summary>
            /// <typeparam name="DbModel"></typeparam>
            /// <param name="dbModel"></param>
            /// <returns></returns>
            public bool FalseDelete<DbModel>(DbModel dbModel) where DbModel : BaseDbModel, new()
            {
                return this.Context.Updateable<DbModel>(dbModel).UpdateColumns(it => new DbModel() { IsDel = true }).ExecuteCommand() > 0;
            }
            /// <summary>
            /// 扩展假删除功能
            /// </summary>
            /// <typeparam name="DbModel"></typeparam>
            /// <param name="dbModel"></param>
            /// <returns></returns>
            public bool FalseDelete<DbModel>(DbModel[] dbModels) where DbModel : BaseDbModel, new()
            {
                return this.Context.Updateable<DbModel>(dbModels).UpdateColumns(it => new DbModel() { IsDel = true }).ExecuteCommand() > 0;
            }
        }
        public class SugarConfigs
        {

            public static Action<string, SugarParameter[]> LogEventStarting = (sql, pars) =>
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < pars.Length; i++)
                {
                    sb.AppendFormat("{0}:{1}", pars[i].ParameterName, pars[i].Value);
                }
                // Tools.MessBox("执行前:" + sql + " ,参数：" + sb.ToString());
                // Logs.Write("sql:" + sql + sb.ToString());
                
            };
            public static Action<string, SugarParameter[]> LogEventCompleted = (sql, pars) =>
            {
                // Console.WriteLine("completed:" + sql + " " + pars);
            };

            /// <summary>
            /// sql执行错误事件
            /// </summary>
            /// <param name="obj"></param>
            public static void ErrorEvent(Exception obj)
            {
                throw new NotImplementedException();
            }
        }
    }
}
