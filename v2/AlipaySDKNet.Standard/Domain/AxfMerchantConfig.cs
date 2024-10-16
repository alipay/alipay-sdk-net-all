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
        /// (1)当config_key=MERCHANT_MSG_APP_ID时，config_value需要是商户的appId
        /// </summary>
        [XmlElement("config_value")]
        public string ConfigValue { get; set; }
    }
}
