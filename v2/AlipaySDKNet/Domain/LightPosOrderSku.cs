using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LightPosOrderSku Data Structure.
    /// </summary>
    [Serializable]
    public class LightPosOrderSku : AopObject
    {
        /// <summary>
        /// 单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品的价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品的数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
