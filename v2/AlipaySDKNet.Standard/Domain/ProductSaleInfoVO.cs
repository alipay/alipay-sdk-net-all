using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductSaleInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ProductSaleInfoVO : AopObject
    {
        /// <summary>
        /// 商品是否可售
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
        /// 商品 id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 商品管控状态
        /// </summary>
        [XmlElement("product_status")]
        public string ProductStatus { get; set; }

        /// <summary>
        /// 商品库存, 合规要求不透出精确值
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 渠道店铺 id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// sku销售信息
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("sku_sale_info_v_o")]
        public List<SkuSaleInfoVO> Skus { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
