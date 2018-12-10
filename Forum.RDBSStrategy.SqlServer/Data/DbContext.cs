using Microsoft.Extensions.Configuration;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.RDBSStrategy.SqlServer.Data
{
    public class DbContext
    {

        public DbContext()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var config = builder.Build();
            db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = config["conn"],
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            });
            db.Ado.IsEnableLogEvent = true;//启用日志事件
            db.Ado.LogEventStarting = SugarConfigs.LogEventStarting;
            db.Ado.LogEventCompleted = SugarConfigs.LogEventCompleted;
        }

        public static SqlSugarClient db { get; set; }

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
                using (var db = DbContext.db)
                {

                    db.Ado.IsEnableLogEvent = false;
                    db.Ado.ExecuteCommand("select 1");
                }
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
