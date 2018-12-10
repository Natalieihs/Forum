using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///商城管理日志表
    ///</summary>
    public partial class SysAdminlogs
    {
           public SysAdminlogs(){


           }
           /// <summary>
           /// Desc:日志id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int logid {get;set;}

           /// <summary>
           /// Desc:用户id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int uid {get;set;}

           /// <summary>
           /// Desc:用户昵称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string userName {get;set;}

           /// <summary>
           /// Desc:管理员组id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short agid {get;set;}

           /// <summary>
           /// Desc:操作
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string operation {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:操作ip
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ip {get;set;}

           /// <summary>
           /// Desc:操作时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime operatetime {get;set;}

    }
}
