using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class SysRole
    {
           public SysRole(){


           }
           /// <summary>
           /// Desc:角色id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:组织结构部门的FK
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? depId {get;set;}

           /// <summary>
           /// Desc:角色类型,取keyvalue 中keytype=2的数据
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int roleType {get;set;}

           /// <summary>
           /// Desc:角色名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:排序号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int sort {get;set;}

           /// <summary>
           /// Desc:0：正常 1：停用
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int status {get;set;}

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

           /// <summary>
           /// Desc:修改用户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? updateId {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updateTime {get;set;}

    }
}
