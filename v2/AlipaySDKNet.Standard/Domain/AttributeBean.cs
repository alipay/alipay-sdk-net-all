using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttributeBean Data Structure.
    /// </summary>
    [Serializable]
    public class AttributeBean : AopObject
    {
        /// <summary>
        /// 属性名
        /// </summary>
        [XmlElement("attribute_name")]
        public string AttributeName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("attribute_value")]
        public string AttributeValue { get; set; }

        /// <summary>
        /// 属性值列表
        /// </summary>
        [XmlArray("attribute_value_list")]
        [XmlArrayItem("string")]
        public List<string> AttributeValueList { get; set; }
    }
}
