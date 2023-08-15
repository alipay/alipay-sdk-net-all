using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StaticDomain Data Structure.
    /// </summary>
    [Serializable]
    public class StaticDomain : AopObject
    {
        /// <summary>
        /// 域名cname
        /// </summary>
        [XmlElement("cname")]
        public string Cname { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [XmlElement("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// 域名类型
        /// </summary>
        [XmlElement("domain_type")]
        public string DomainType { get; set; }

        /// <summary>
        /// 域名状态。 not_exist：表示该域名还未在系统内创建 init：域名正在进行配置初始化 init_fail：域名初始化失败 normal：域名正常提供服务中 stopped：域名已经被停止服务 deleted：域名已经被销毁
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
