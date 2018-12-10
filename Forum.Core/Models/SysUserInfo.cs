using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class SysUserInfo
    {
           public SysUserInfo(){


           }
           /// <summary>
           /// Desc:用户主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int id {get;set;}

           /// <summary>
           /// Desc:登录用户名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string loginName {get;set;}

           /// <summary>
           /// Desc:用户密码MD5加密
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string loginPWD {get;set;}

           /// <summary>
           /// Desc:真实名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string realName {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string telphone {get;set;}

           /// <summary>
           /// Desc:手机
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mobile {get;set;}

           /// <summary>
           /// Desc:电邮
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string emial {get;set;}

           /// <summary>
           /// Desc:QQ
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string qq {get;set;}

           /// <summary>
           /// Desc:性别 0:女 1：男 2：保密
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int gender {get;set;}

           /// <summary>
           /// Desc:0：正常 1：停用
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int status {get;set;}

           /// <summary>
           /// Desc:组织结构公司的FK
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? companyId {get;set;}

           /// <summary>
           /// Desc:组织结构部门的FK
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? depId {get;set;}

           /// <summary>
           /// Desc:组织结构工作组的FK
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? workGroupId {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:创建用户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? creatorId {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
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
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime updateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? gid {get;set;}

    }
}
