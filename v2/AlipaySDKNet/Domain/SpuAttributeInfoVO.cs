using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpuAttributeInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class SpuAttributeInfoVO : AopObject
    {
        /// <summary>
        /// 属性KEY
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// SPU属性名称
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }

        /// <summary>
        /// 属性值id
        /// </summary>
        [XmlElement("attr_value_id")]
        public string AttrValueId { get; set; }
    }
}
