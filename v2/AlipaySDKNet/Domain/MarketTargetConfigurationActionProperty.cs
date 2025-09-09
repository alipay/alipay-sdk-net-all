using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketTargetConfigurationActionProperty Data Structure.
    /// </summary>
    [Serializable]
    public class MarketTargetConfigurationActionProperty : AopObject
    {
        /// <summary>
        /// 营销目标配置类别
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 营销目标配置类别对应值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
