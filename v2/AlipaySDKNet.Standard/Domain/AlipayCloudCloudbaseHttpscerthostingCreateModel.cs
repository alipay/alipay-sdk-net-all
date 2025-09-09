using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpscerthostingCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseHttpscerthostingCreateModel : AopObject
    {
        /// <summary>
        /// acme需要的key列表
        /// </summary>
        [XmlArray("acme_key_configs")]
        [XmlArrayItem("acme_key_config")]
        public List<AcmeKeyConfig> AcmeKeyConfigs { get; set; }

        /// <summary>
        /// 小程序云应用ID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云环境ID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

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
        /// 域名类型  - FUNCTION  - STATIC_SITE
        /// </summary>
        [XmlElement("domain_type")]
        public string DomainType { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 托管是否开启
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }
    }
}
