using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class SysFunction
    {
           public SysFunction(){


           }
           /// <summary>
           /// Desc:操作按钮方式表
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:菜单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int mId {get;set;}

           /// <summary>
           /// Desc:操作方法描述
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:操作方法英文标示
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string function {get;set;}

           /// <summary>
           /// Desc:操作方法图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string picname {get;set;}

           /// <summary>
           /// Desc:0:有效 1：停用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:创建用户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? creatorId {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? createTime {get;set;}

           /// <summary>
           /// Desc:修改用户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? updateId {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? updateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? position {get;set;}

    }
}
