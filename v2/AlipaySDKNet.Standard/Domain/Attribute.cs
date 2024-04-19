using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Attribute Data Structure.
    /// </summary>
    [Serializable]
    public class Attribute : AopObject
    {
        /// <summary>
        /// 扩展属性的key，由支付宝侧定义分配
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性的值，如果“单一值”，数组只有一项；如果是“多值”，则数组对应有多项。
        /// </summary>
        [XmlArray("value")]
        [XmlArrayItem("string")]
        public List<string> Value { get; set; }
    }
}
