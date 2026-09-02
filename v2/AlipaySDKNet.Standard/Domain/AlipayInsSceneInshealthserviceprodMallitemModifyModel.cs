using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodMallitemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInshealthserviceprodMallitemModifyModel : AopObject
    {
        /// <summary>
        /// 商品名
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 标签id列表
        /// </summary>
        [XmlArray("label_id_list")]
        [XmlArrayItem("string")]
        public List<string> LabelIdList { get; set; }

        /// <summary>
        /// 图片列表
        /// </summary>
        [XmlArray("pic_list")]
        [XmlArrayItem("external_item_pic")]
        public List<ExternalItemPic> PicList { get; set; }

        /// <summary>
        /// 类目属性列表
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
    }
}
