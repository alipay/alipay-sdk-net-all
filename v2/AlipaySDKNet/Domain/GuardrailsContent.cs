using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GuardrailsContent Data Structure.
    /// </summary>
    [Serializable]
    public class GuardrailsContent : AopObject
    {
        /// <summary>
        /// 属性code
        /// </summary>
        [XmlElement("property_code")]
        public string PropertyCode { get; set; }

        /// <summary>
        /// 内容格式
        /// </summary>
        [XmlElement("property_format")]
        public string PropertyFormat { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("property_value")]
        public string PropertyValue { get; set; }
    }
}
