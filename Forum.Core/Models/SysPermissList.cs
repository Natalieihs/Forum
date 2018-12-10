using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class SysPermissList
    {
           public SysPermissList(){


           }
           /// <summary>
           /// Desc:权限列表主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:角色id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int rId {get;set;}

           /// <summary>
           /// Desc:菜单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int mId {get;set;}

           /// <summary>
           /// Desc:操作按钮方式id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int fId {get;set;}

           /// <summary>
           /// Desc:创建用户
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int creatorId {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime createTime {get;set;}

    }
}
