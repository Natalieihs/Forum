using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class SysMenus
    {
           public SysMenus(){


           }
           /// <summary>
           /// Desc:菜单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:父级菜单编号
           /// Default:N'-1'
           /// Nullable:False
           /// </summary>           
           public int parentId {get;set;}

           /// <summary>
           /// Desc:菜单名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:菜单地址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string url {get;set;}

           /// <summary>
           /// Desc:区域
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string area {get;set;}

           /// <summary>
           /// Desc:控制器
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string controller {get;set;}

           /// <summary>
           /// Desc:方法
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string action {get;set;}

           /// <summary>
           /// Desc:排序编号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int sortid {get;set;}

           /// <summary>
           /// Desc:0:正常 1：停用
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int status {get;set;}

           /// <summary>
           /// Desc:菜单图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string picName {get;set;}

           /// <summary>
           /// Desc:菜单级别 0:根菜单 1一级菜单 2:二级菜单
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int level {get;set;}

           /// <summary>
           /// Desc:备用字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exp1 {get;set;}

           /// <summary>
           /// Desc:备用字段 0:表示在左菜单要显示  1：在左菜单不显示，权限是需要管控
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? exp2 {get;set;}

           /// <summary>
           /// Desc:创建用户
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int creatorId {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
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
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? updateTime {get;set;}

    }
}
