using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfMerchantConfig Data Structure.
    /// </summary>
    [Serializable]
    public class AxfMerchantConfig : AopObject
    {
        /// <summary>
        /// 配置key
        /// </summary>
        [XmlElement("config_key")]
        public string ConfigKey { get; set; }

        /// <summary>
        /// 配置value
        /// </summary>
        [XmlElement("config_value")]
        public string ConfigValue { get; set; }
    }
}
