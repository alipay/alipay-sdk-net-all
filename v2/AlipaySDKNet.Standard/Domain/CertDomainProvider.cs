using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertDomainProvider Data Structure.
    /// </summary>
    [Serializable]
    public class CertDomainProvider : AopObject
    {
        /// <summary>
        /// acme需要的key列表
        /// </summary>
        [XmlArray("acme_key_configs")]
        [XmlArrayItem("acme_key_config")]
        public List<AcmeKeyConfig> AcmeKeyConfigs { get; set; }

        /// <summary>
        /// 服务提供商展示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 服务提供商名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
