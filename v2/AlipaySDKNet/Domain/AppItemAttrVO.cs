using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemAttrVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemAttrVO : AopObject
    {
        /// <summary>
        /// 商品属性key
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 商品属性value
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
