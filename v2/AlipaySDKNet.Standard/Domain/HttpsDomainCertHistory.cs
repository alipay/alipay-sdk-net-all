using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HttpsDomainCertHistory Data Structure.
    /// </summary>
    [Serializable]
    public class HttpsDomainCertHistory : AopObject
    {
        /// <summary>
        /// acme日志
        /// </summary>
        [XmlElement("acme_log")]
        public string AcmeLog { get; set; }

        /// <summary>
        /// 证书
        /// </summary>
        [XmlElement("cert")]
        public string Cert { get; set; }

        /// <summary>
        /// 证书链
        /// </summary>
        [XmlElement("fullchain_cert")]
        public string FullchainCert { get; set; }

        /// <summary>
        /// 证书
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 签署状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 历史记录更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
