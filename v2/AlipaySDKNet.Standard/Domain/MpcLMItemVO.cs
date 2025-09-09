using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcLMItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class MpcLMItemVO : AopObject
    {
        /// <summary>
        /// 商品规格属性，可作为商品的筛选维度
        /// </summary>
        [XmlArray("attr")]
        [XmlArrayItem("product_property")]
        public List<ProductProperty> Attr { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 是否可售
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 类目链
        /// </summary>
        [XmlElement("category_chain")]
        public LmCategoryVO CategoryChain { get; set; }

        /// <summary>
        /// 多端商城商品id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品详情图链接
        /// </summary>
        [XmlElement("desc_path")]
        public string DescPath { get; set; }

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
        /// 商品副图链接
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 商品主图链接
        /// </summary>
        [XmlElement("main_pic")]
        public string MainPic { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("mpc_item_id")]
        public string MpcItemId { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("mpc_sku_vo")]
        [XmlArrayItem("mpc_lm_sku_v_o")]
        public List<MpcLmSkuVO> MpcSkuVo { get; set; }

        /// <summary>
        /// 商品属性，是商品描述字面量
        /// </summary>
        [XmlArray("product_properties")]
        [XmlArrayItem("product_property")]
        public List<ProductProperty> ProductProperties { get; set; }

        /// <summary>
        /// 商品管控状态
        /// </summary>
        [XmlElement("product_status")]
        public string ProductStatus { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 渠道店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 模糊销量
        /// </summary>
        [XmlElement("sold_quantity")]
        public string SoldQuantity { get; set; }

        /// <summary>
        /// 税码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// 税率百分比
        /// </summary>
        [XmlElement("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
