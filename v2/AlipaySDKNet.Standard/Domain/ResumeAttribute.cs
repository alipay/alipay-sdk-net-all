using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResumeAttribute Data Structure.
    /// </summary>
    [Serializable]
    public class ResumeAttribute : AopObject
    {
        /// <summary>
        /// 数据key
        /// </summary>
        [XmlElement("attribute_key")]
        public string AttributeKey { get; set; }

        /// <summary>
        /// 数据值
        /// </summary>
        [XmlElement("attribute_value")]
        public string AttributeValue { get; set; }
    }
}
