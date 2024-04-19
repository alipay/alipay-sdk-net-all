using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessDomainGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessDomainGetResponse : AopResponse
    {
        /// <summary>
        /// 目标CNAME地址
        /// </summary>
        [XmlElement("cname")]
        public string Cname { get; set; }

        /// <summary>
        /// 是否为强制HTTPS
        /// </summary>
        [XmlElement("force_https")]
        public bool ForceHttps { get; set; }

        /// <summary>
        /// 是否有证书
        /// </summary>
        [XmlElement("has_cert")]
        public bool HasCert { get; set; }

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
