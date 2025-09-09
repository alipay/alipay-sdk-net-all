using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudGateway Data Structure.
    /// </summary>
    [Serializable]
    public class CloudGateway : AopObject
    {
        /// <summary>
        /// 目标CNAME地址
        /// </summary>
        [XmlElement("cname")]
        public string Cname { get; set; }

        /// <summary>
        /// 备案状态 - CONNECTED：已备案已接入 - UNCONNECT：已备案未接入
        /// </summary>
        [XmlElement("connect_status")]
        public string ConnectStatus { get; set; }

        /// <summary>
        /// 是否为自定义域名
        /// </summary>
        [XmlElement("custom")]
        public bool Custom { get; set; }

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
        /// 自定义网关域名
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
