using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemPromoActivityAttrDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPromoActivityAttrDTO : AopObject
    {
        /// <summary>
        /// 属性key
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 属性 value
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
