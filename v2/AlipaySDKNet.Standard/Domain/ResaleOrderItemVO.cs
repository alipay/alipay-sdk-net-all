using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResaleOrderItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class ResaleOrderItemVO : AopObject
    {
        /// <summary>
        /// 小程序商品库的itemId
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 单位：元
        /// </summary>
        [XmlElement("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_quantity")]
        public string ItemQuantity { get; set; }

        /// <summary>
        /// 若商家没有走小程序商品库，则回传商家自己的外部商品id（公域要去必须走小程序商品库）
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 外部商户商品名称
        /// </summary>
        [XmlElement("out_item_name")]
        public string OutItemName { get; set; }

        /// <summary>
        /// 商品下唯一的skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
