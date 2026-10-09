using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LabelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LabelDTO : AopObject
    {
        /// <summary>
        /// label 不唯一 spi不支持map，该dto作为tenantDTO的map 无枚举 被调用方提供 无特殊说明
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// value 不唯一 spi不支持map，所以使用该dto作为map，该值为value 无枚举 无特殊说明
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
