using System;
using XS.DataProfile.CustomEntity;
using XS.DataProfile.Dapper.Contrib;

namespace ProxyIpTools.Core.Entity
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; } 

    }
    [Table("xs_apis")]//实际表名称，如果不添加将默认类名称
    public class Apis: EntityBase
    {
      
        public string Url { get; set; }

    }
    [Table("xs_ips")]
    public class Ips: EntityBase
    {

        public string Ip { get; set; }
        public int Port { get; set; }
        public string MdWu { get; set; }
        ///// <summary>
        ///// 响应时间
        ///// </summary>
        //public int Times { get; set; }
        ///// <summary>
        ///// 是否有效
        ///// </summary>
        //public int IsOk { get; set; }
    }

    [Table("xs_texturls")]
    public class TestUrls : EntityBase
    {
        public string Url { get; set; } 
        public string TestName { get; set; } 
        public string CheckStr { get; set; }
    }
    [Table("xs_urlipsforok")]
    public class UrlIpsForOk : EntityBase
    {
        public int UrlId { get; set; }
        public int IpId { get; set; }
        public string Url { get; set; }
        public string Ip { get; set; }
        public string Report { get; set; }
        /// <summary>
        /// 是否有效
        /// </summary>
        public int IsOk { get; set; }
        public int Port { get; set; }
        /// <summary>
        /// 响应时间
        /// </summary>
        public int Times { get; set; }
        public string MdWu { get; set; }
        public string MdWuIpPort { get; set; }
    }
}
