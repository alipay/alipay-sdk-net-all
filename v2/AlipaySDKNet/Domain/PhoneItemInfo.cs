using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PhoneItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PhoneItemInfo : AopObject
    {
        /// <summary>
        /// 话费面额，这里单位是元。
        /// </summary>
        [XmlElement("face")]
        public string Face { get; set; }

        /// <summary>
        /// 商品最终价格，这里单位是元。
        /// </summary>
        [XmlElement("final_price")]
        public string FinalPrice { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品价格，这里单位是元。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 话费商品来源，比如direct 代表直连
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
