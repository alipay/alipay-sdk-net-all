using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StoreOrderGood Data Structure.
    /// </summary>
    [Serializable]
    public class StoreOrderGood : AopObject
    {
        /// <summary>
        /// 商品的ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 规格的ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
