using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///在线用户表
    ///</summary>
    public partial class bma_onlineusers
    {
           public bma_onlineusers(){


           }
           /// <summary>
           /// Desc:在线id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int olid {get;set;}

           /// <summary>
           /// Desc:用户id
           /// Default:-1
           /// Nullable:False
           /// </summary>           
           public int uid {get;set;}

           /// <summary>
           /// Desc:用户sessionid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string sid {get;set;}

           /// <summary>
           /// Desc:用户昵称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string nickname {get;set;}

           /// <summary>
           /// Desc:用户ip
           /// Default:0.0.0.0
           /// Nullable:False
           /// </summary>           
           public string ip {get;set;}

           /// <summary>
           /// Desc:用户所在区域id
           /// Default:-1
           /// Nullable:False
           /// </summary>           
           public short regionid {get;set;}

           /// <summary>
           /// Desc:最后更新时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime updatetime {get;set;}

    }
}
