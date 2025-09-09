using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyProductConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyProductConfigInfo : AopObject
    {
        /// <summary>
        /// 企业发票产品配置键
        /// </summary>
        [XmlElement("config_key")]
        public string ConfigKey { get; set; }

        /// <summary>
        /// 企业发票产品配置值
        /// </summary>
        [XmlElement("config_value")]
        public string ConfigValue { get; set; }
    }
}
