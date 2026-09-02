using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalItemPropery Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalItemPropery : AopObject
    {
        /// <summary>
        /// 输入型属性值
        /// </summary>
        [XmlElement("ext_value")]
        public string ExtValue { get; set; }

        /// <summary>
        /// 属性ID
        /// </summary>
        [XmlElement("property_id")]
        public string PropertyId { get; set; }

        /// <summary>
        /// 属性值ID
        /// </summary>
        [XmlElement("value_id")]
        public string ValueId { get; set; }
    }
}
