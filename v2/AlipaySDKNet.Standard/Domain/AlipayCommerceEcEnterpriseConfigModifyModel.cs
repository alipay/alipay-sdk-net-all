using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseConfigModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseConfigModifyModel : AopObject
    {
        /// <summary>
        /// 企业所需配置的key
        /// </summary>
        [XmlElement("config_key")]
        public string ConfigKey { get; set; }

        /// <summary>
        /// 企业所需配置的value
        /// </summary>
        [XmlElement("config_value")]
        public bool ConfigValue { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
