using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///新闻表
    ///</summary>
    public partial class bma_news
    {
           public bma_news(){


           }
           /// <summary>
           /// Desc:新闻id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int newsid {get;set;}

           /// <summary>
           /// Desc:新闻类型id
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public short newstypeid {get;set;}

           /// <summary>
           /// Desc:是否展示
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte isshow {get;set;}

           /// <summary>
           /// Desc:是否置顶
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte istop {get;set;}

           /// <summary>
           /// Desc:是否置首
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte ishome {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int displayorder {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime addtime {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string title {get;set;}

           /// <summary>
           /// Desc:链接地址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string url {get;set;}

           /// <summary>
           /// Desc:新闻内容
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string body {get;set;}

    }
}
