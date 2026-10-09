using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkedMallItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LinkedMallItemDTO : AopObject
    {
        /// <summary>
        /// 商品品牌
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 商品是否可售，true-可售，false-禁售
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 商品所属叶子类目到根类目的路径
        /// </summary>
        [XmlArray("category_chain")]
        [XmlArrayItem("lm_category_v_o")]
        public List<LmCategoryVO> CategoryChain { get; set; }

        /// <summary>
        /// 商品类目id
        /// </summary>
        [XmlElement("category_leaf_id")]
        public string CategoryLeafId { get; set; }

        /// <summary>
        /// 描述链接
        /// </summary>
        [XmlElement("desc_path")]
        public string DescPath { get; set; }

        /// <summary>
        /// 商品地区码
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 渠道商商品模糊库存
        /// </summary>
        [XmlElement("fuzzy_quantity")]
        public string FuzzyQuantity { get; set; }

        /// <summary>
        /// 商品副图链接
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 商品主图链接，从oss获取
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 商品规格，是商品的辅助筛选维度
        /// </summary>
        [XmlArray("product_specs")]
        [XmlArrayItem("linked_mall_item_spec_d_t_o")]
        public List<LinkedMallItemSpecDTO> ProductSpecs { get; set; }

        /// <summary>
        /// 商品的上架状态
        /// </summary>
        [XmlElement("product_status")]
        public string ProductStatus { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 商品属性，是商品的描述字面量，仅用于展示
        /// </summary>
        [XmlArray("properties")]
        [XmlArrayItem("linked_mall_item_prop_d_t_o")]
        public List<LinkedMallItemPropDTO> Properties { get; set; }

        /// <summary>
        /// 商品库存
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 渠道店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商品sku信息
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("linked_mall_sku_d_t_o")]
        public List<LinkedMallSkuDTO> Skus { get; set; }

        /// <summary>
        /// 模糊销量
        /// </summary>
        [XmlElement("sold_quantity")]
        public string SoldQuantity { get; set; }

        /// <summary>
        /// 商品税码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// 百分位税率
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
