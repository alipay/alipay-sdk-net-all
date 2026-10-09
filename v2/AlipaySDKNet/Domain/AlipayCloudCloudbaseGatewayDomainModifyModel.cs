using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseGatewayDomainModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseGatewayDomainModifyModel : AopObject
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
        /// 是否强制HTTPS
        /// </summary>
        [XmlElement("force_https")]
        public bool ForceHttps { get; set; }

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
