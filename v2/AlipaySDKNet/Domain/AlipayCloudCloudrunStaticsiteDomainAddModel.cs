using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteDomainAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunStaticsiteDomainAddModel : AopObject
    {
        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 私钥，pem格式。
        /// </summary>
        [XmlElement("cert_private_key")]
        public string CertPrivateKey { get; set; }

        /// <summary>
        /// 证书，pem格式
        /// </summary>
        [XmlElement("certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// 域名。输入你的自定义域名。
        /// </summary>
        [XmlElement("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// 是否开启https
        /// </summary>
        [XmlElement("enable_https")]
        public bool EnableHttps { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
