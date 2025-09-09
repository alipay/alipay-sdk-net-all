using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttributeValueInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AttributeValueInfo : AopObject
    {
        /// <summary>
        /// 属性值别名
        /// </summary>
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 属性值名称
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }

        /// <summary>
        /// 属性值ID
        /// </summary>
        [XmlElement("value_id")]
        public string ValueId { get; set; }
    }
}
