using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpIndicatorIndustryCountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpIndicatorIndustryCountInfo : AopObject
    {
        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 指标key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
