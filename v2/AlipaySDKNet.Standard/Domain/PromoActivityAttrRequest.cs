using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoActivityAttrRequest Data Structure.
    /// </summary>
    [Serializable]
    public class PromoActivityAttrRequest : AopObject
    {
        /// <summary>
        /// 属性的 key
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
