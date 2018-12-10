using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///后台IP白名单表，在表中的IP才被允许登入后台
    ///</summary>
    public partial class SysIPWhiteList
    {
           public SysIPWhiteList(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdateTime {get;set;}

           /// <summary>
           /// Desc:IP地址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string IP {get;set;}

           /// <summary>
           /// Desc:备注信息
           /// Default:NULL
           /// Nullable:True
           /// </summary>           
           public string Remarks {get;set;}

    }
}
