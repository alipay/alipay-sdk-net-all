using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpuAttribute Data Structure.
    /// </summary>
    [Serializable]
    public class SpuAttribute : AopObject
    {
        /// <summary>
        /// 商品属性名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品属性值
        /// </summary>
        [XmlArray("value")]
        [XmlArrayItem("string")]
        public List<string> Value { get; set; }
    }
}
