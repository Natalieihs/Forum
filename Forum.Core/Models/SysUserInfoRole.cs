using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class SysUserInfoRole
    {
           public SysUserInfoRole(){


           }
           /// <summary>
           /// Desc:用户所属角色中间表
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:用户主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int uId {get;set;}

           /// <summary>
           /// Desc:角色id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int rId {get;set;}

    }
}
