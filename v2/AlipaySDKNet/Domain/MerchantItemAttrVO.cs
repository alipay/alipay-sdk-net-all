using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantItemAttrVO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantItemAttrVO : AopObject
    {
        /// <summary>
        /// 商家侧商品属性key，如available_city_codes可售城市编码等
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 商家侧商品属性值，与attr_key相对应。
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
