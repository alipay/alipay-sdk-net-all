using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessDomainCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseHttpaccessDomainCreateModel : AopObject
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
        /// -----BEGIN CERTIFICATE----- MIICizCCAfQCCQCCV7Beh2T ...... Yavrq6iaDVj8s1YWg0DX5xI -----END CERTIFICATE-----
        /// </summary>
        [XmlElement("ssl_cert")]
        public string SslCert { get; set; }

        /// <summary>
        /// -----BEGIN RSA PRIVATE KEY----- MIICXgIBAAKBgQDn6yPnXiH ...... PpJ76GhptJ5sA7ZS6hAGX1w -----END RSA PRIVATE KEY-----
        /// </summary>
        [XmlElement("ssl_key")]
        public string SslKey { get; set; }
    }
}
