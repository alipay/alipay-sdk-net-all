using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemProperty Data Structure.
    /// </summary>
    [Serializable]
    public class ItemProperty : AopObject
    {
        /// <summary>
        /// 属性；内容不能有空格
        /// </summary>
        [XmlElement("prop_key")]
        public string PropKey { get; set; }

        /// <summary>
        /// 属性值；内容不能有空格
        /// </summary>
        [XmlArray("prop_values")]
        [XmlArrayItem("string")]
        public List<string> PropValues { get; set; }
    }
}
