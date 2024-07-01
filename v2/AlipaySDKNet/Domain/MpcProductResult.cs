using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcProductResult Data Structure.
    /// </summary>
    [Serializable]
    public class MpcProductResult : AopObject
    {
        /// <summary>
        /// 是否可售
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 商品价格(单位：分)
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 商品图片链接
        /// </summary>
        [XmlElement("product_pic_url")]
        public string ProductPicUrl { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("product_title")]
        public string ProductTitle { get; set; }

        /// <summary>
        /// 采购方id
        /// </summary>
        [XmlElement("purchaser_id")]
        public string PurchaserId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// SKUID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        [XmlElement("sku_title")]
        public string SkuTitle { get; set; }
    }
}
