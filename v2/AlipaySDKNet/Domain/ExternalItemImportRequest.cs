using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalItemImportRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalItemImportRequest : AopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 标签id列表
        /// </summary>
        [XmlArray("label_id_list")]
        [XmlArrayItem("string")]
        public List<string> LabelIdList { get; set; }

        /// <summary>
        /// 商品图片列表 当前字段已废弃(字段类型录错了，录入时图片列表用新字段picture_list)
        /// </summary>
        [XmlArray("pic_list")]
        [XmlArrayItem("string")]
        public List<string> PicList { get; set; }

        /// <summary>
        /// 图片列表
        /// </summary>
        [XmlArray("picture_list")]
        [XmlArrayItem("external_item_pic")]
        public List<ExternalItemPic> PictureList { get; set; }

        /// <summary>
        /// 商品属性列表
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("external_item_propery")]
        public List<ExternalItemPropery> PropertyList { get; set; }

        /// <summary>
        /// 销售规则列表
        /// </summary>
        [XmlArray("sale_rule_list")]
        [XmlArrayItem("external_sale_rule")]
        public List<ExternalSaleRule> SaleRuleList { get; set; }

        /// <summary>
        /// 服务产品ID
        /// </summary>
        [XmlElement("ser_prod_no")]
        public string SerProdNo { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("external_s_k_u")]
        public List<ExternalSKU> SkuList { get; set; }

        /// <summary>
        /// 商家商品Id
        /// </summary>
        [XmlElement("source_product_id")]
        public string SourceProductId { get; set; }

        /// <summary>
        /// 供应状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
