using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkedMallItemPropDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LinkedMallItemPropDTO : AopObject
    {
        /// <summary>
        /// 商品属性名
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 商品属性值
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("string")]
        public List<string> Values { get; set; }
    }
}
