using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalCatePropertyValue Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalCatePropertyValue : AopObject
    {
        /// <summary>
        /// 所属属性ID
        /// </summary>
        [XmlElement("property_id")]
        public string PropertyId { get; set; }

        /// <summary>
        /// 属性值别名
        /// </summary>
        [XmlElement("value_alias")]
        public string ValueAlias { get; set; }

        /// <summary>
        /// 属性值ID
        /// </summary>
        [XmlElement("value_id")]
        public string ValueId { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("value_name")]
        public string ValueName { get; set; }
    }
}
