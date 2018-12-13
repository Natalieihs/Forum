using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///在线时间表
    ///</summary>
    public partial class bma_onlinetime
    {
           public bma_onlinetime(){


           }
           /// <summary>
           /// Desc:用户id
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int uid {get;set;}

           /// <summary>
           /// Desc:总在线时间
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int total {get;set;}

           /// <summary>
           /// Desc:今年在线时间
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int year {get;set;}

           /// <summary>
           /// Desc:本月在线时间
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public short month {get;set;}

           /// <summary>
           /// Desc:本周在线时间
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public short week {get;set;}

           /// <summary>
           /// Desc:今天在线时间
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public short day {get;set;}

           /// <summary>
           /// Desc:最后更新时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime updatetime {get;set;}

    }
}
