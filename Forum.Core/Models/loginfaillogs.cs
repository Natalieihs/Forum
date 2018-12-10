using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///登陆失败日志表
    ///</summary>
    public partial class loginfaillogs
    {
           public loginfaillogs(){


           }
           /// <summary>
           /// Desc:日志id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:登陆ip
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long loginip {get;set;}

           /// <summary>
           /// Desc:失败次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte failtimes {get;set;}

           /// <summary>
           /// Desc:最后登陆时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime lastlogintime {get;set;}

    }
}
