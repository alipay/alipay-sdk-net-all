using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemSkuAttrVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSkuAttrVO : AopObject
    {
        /// <summary>
        /// 销售属性key值
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 属性的类型，选填，不填时默认赋值spec
        /// </summary>
        [XmlElement("attr_type")]
        public string AttrType { get; set; }

        /// <summary>
        /// 销售属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
