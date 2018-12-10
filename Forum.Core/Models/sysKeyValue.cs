using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class sysKeyValue
    {
           public sysKeyValue(){


           }
           /// <summary>
           /// Desc:数据字典PK
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int KID {get;set;}

           /// <summary>
           /// Desc:数据字典父ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ParentID {get;set;}

           /// <summary>
           /// Desc:数据字典类别 1：组织结构
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int KType {get;set;}

           /// <summary>
           /// Desc:数据字典名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string KName {get;set;}

           /// <summary>
           /// Desc:数据字典值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Kvalue {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KRemark {get;set;}

    }
}
