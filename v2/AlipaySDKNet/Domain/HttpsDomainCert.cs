using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HttpsDomainCert Data Structure.
    /// </summary>
    [Serializable]
    public class HttpsDomainCert : AopObject
    {
        /// <summary>
        /// 证书到期时间
        /// </summary>
        [XmlElement("cert_expiration_time")]
        public string CertExpirationTime { get; set; }

        /// <summary>
        /// 证书注册时间
        /// </summary>
        [XmlElement("cert_sign_time")]
        public string CertSignTime { get; set; }

        /// <summary>
        /// 证书描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [XmlElement("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 域名服务商  - aliyun  - cloudflare  - dnspod  - godaddy
        /// </summary>
        [XmlElement("domain_provider")]
        public string DomainProvider { get; set; }

        /// <summary>
        /// 域名状态  - DOMAIN_UNVALID  - CERT_INIT  - CERT_SUCCESS
        /// </summary>
        [XmlElement("domain_status")]
        public string DomainStatus { get; set; }

        /// <summary>
        /// 域名类型
        /// </summary>
        [XmlElement("domain_type")]
        public string DomainType { get; set; }

        /// <summary>
        /// https证书ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 证书托管是否开启
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }
    }
}
