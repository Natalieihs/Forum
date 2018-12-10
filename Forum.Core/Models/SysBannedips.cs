using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///禁止ip表
    ///</summary>
    public partial class SysBannedips
    {
           public SysBannedips(){


           }
           /// <summary>
           /// Desc:自增id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:ip地址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ip {get;set;}

           /// <summary>
           /// Desc:解禁时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime liftbantime {get;set;}

    }
}
