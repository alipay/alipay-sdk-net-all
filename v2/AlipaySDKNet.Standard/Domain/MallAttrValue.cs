using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MallAttrValue Data Structure.
    /// </summary>
    [Serializable]
    public class MallAttrValue : AopObject
    {
        /// <summary>
        /// 属性Id，非必传
        /// </summary>
        [XmlElement("attr_id")]
        public string AttrId { get; set; }

        /// <summary>
        /// 属性名称描述，用户录入
        /// </summary>
        [XmlElement("attr_name")]
        public string AttrName { get; set; }

        /// <summary>
        /// 属性值，用户录入，如 TXMZFM00762542，对应的Id
        /// </summary>
        [XmlElement("attr_value_id")]
        public string AttrValueId { get; set; }

        /// <summary>
        /// 属性值名称，用户录入
        /// </summary>
        [XmlElement("attr_value_name")]
        public string AttrValueName { get; set; }
    }
}
