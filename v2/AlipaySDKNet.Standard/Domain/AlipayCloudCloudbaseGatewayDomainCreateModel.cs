using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseGatewayDomainCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseGatewayDomainCreateModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 证书文本
        /// </summary>
        [XmlElement("ssl_cert")]
        public string SslCert { get; set; }

        /// <summary>
        /// 私钥文本
        /// </summary>
        [XmlElement("ssl_key")]
        public string SslKey { get; set; }
    }
}
