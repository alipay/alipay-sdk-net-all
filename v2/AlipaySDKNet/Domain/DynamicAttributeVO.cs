using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DynamicAttributeVO Data Structure.
    /// </summary>
    [Serializable]
    public class DynamicAttributeVO : AopObject
    {
        /// <summary>
        /// 属性别名，英文名
        /// </summary>
        [XmlElement("attr_alias")]
        public string AttrAlias { get; set; }

        /// <summary>
        /// 属性值为JSONArray格式的字符串，不同value_type的组装格式不同 文本：  是否： 离散： 数值：
        /// </summary>
        [XmlArray("attr_value")]
        [XmlArrayItem("string")]
        public List<string> AttrValue { get; set; }

        /// <summary>
        /// 属性值类型
        /// </summary>
        [XmlElement("value_type")]
        public string ValueType { get; set; }
    }
}
