using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuSaleInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class SkuSaleInfoVO : AopObject
    {
        /// <summary>
        /// sku 是否可售
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 地区码
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 模糊库存，合规要求不透出精确库存，使用模糊库存描述
        /// </summary>
        [XmlElement("fuzzy_quantity")]
        public string FuzzyQuantity { get; set; }

        /// <summary>
        /// 划线价, 即指导价，单位分
        /// </summary>
        [XmlElement("mark_price")]
        public long MarkPrice { get; set; }

        /// <summary>
        /// 售价,单位分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品 Id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 商品库存, 合规要求不透出精确值
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 渠道店铺 Id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku 管控状态
        /// </summary>
        [XmlElement("sku_status")]
        public string SkuStatus { get; set; }

        /// <summary>
        /// sku标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
