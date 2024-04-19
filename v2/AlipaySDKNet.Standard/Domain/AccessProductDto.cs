using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessProductDto Data Structure.
    /// </summary>
    [Serializable]
    public class AccessProductDto : AopObject
    {
        /// <summary>
        /// buyer_work_no，用于商品同步，由调用方传入。
        /// </summary>
        [XmlElement("buyer_work_no")]
        public string BuyerWorkNo { get; set; }

        /// <summary>
        /// catalog_category_id，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("catalog_category_id")]
        public long CatalogCategoryId { get; set; }

        /// <summary>
        /// category_code，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// data_source，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// img_url_list，用于商品同步，由调用方传入
        /// </summary>
        [XmlArray("img_url_list")]
        [XmlArrayItem("string")]
        public List<string> ImgUrlList { get; set; }

        /// <summary>
        /// lead_pur_org，用于商品同步，由调用方传入
        /// </summary>
        [XmlArray("leading_pur_org")]
        [XmlArrayItem("string")]
        public List<string> LeadingPurOrg { get; set; }

        /// <summary>
        /// mall_url，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("mall_url")]
        public string MallUrl { get; set; }

        /// <summary>
        /// order_type，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// product_attr_value_list，用于商品同步，由调用方传入
        /// </summary>
        [XmlArray("product_attr_value_list")]
        [XmlArrayItem("access_product_attr_value_dto")]
        public List<AccessProductAttrValueDto> ProductAttrValueList { get; set; }

        /// <summary>
        /// product_desc，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("product_desc")]
        public string ProductDesc { get; set; }

        /// <summary>
        /// product_name，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// purchase_channel，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("purchase_channel")]
        public string PurchaseChannel { get; set; }

        /// <summary>
        /// recommendation，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("recommendation")]
        public string Recommendation { get; set; }

        /// <summary>
        /// source_category_id，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("source_category_id")]
        public long SourceCategoryId { get; set; }

        /// <summary>
        /// source_category_name，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("source_category_name")]
        public string SourceCategoryName { get; set; }

        /// <summary>
        /// source_type，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// source_value，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("source_value")]
        public string SourceValue { get; set; }

        /// <summary>
        /// unit，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
