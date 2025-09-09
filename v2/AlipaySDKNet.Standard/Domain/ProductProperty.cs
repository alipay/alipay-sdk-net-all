using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductProperty Data Structure.
    /// </summary>
    [Serializable]
    public class ProductProperty : AopObject
    {
        /// <summary>
        /// 属性名
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("string")]
        public List<string> Values { get; set; }
    }
}
