using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PunchoutAccessProductDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PunchoutAccessProductDTO : AopObject
    {
        /// <summary>
        /// brand_id，用于punchout模式产品同步
        /// </summary>
        [XmlElement("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// brand_name，用于punchout模式产品同步
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// buyer_work_no，用于punchout模式产品同步
        /// </summary>
        [XmlElement("buyer_work_no")]
        public string BuyerWorkNo { get; set; }

        /// <summary>
        /// catalog_category_id，用于punchout模式产品同步
        /// </summary>
        [XmlElement("catalog_category_id")]
        public long CatalogCategoryId { get; set; }

        /// <summary>
        /// category_code，用于punchout模式产品同步
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// category_id,用于punchout模式产品同步
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// category_use_id，用于punchout模式产品同步
        /// </summary>
        [XmlElement("category_use_id")]
        public long CategoryUseId { get; set; }

        /// <summary>
        /// data_source,用于punchout模式产品同步
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// front_category_id,用于punchout模式产品同步
        /// </summary>
        [XmlElement("front_category_id")]
        public long FrontCategoryId { get; set; }

        /// <summary>
        /// img_storage_type，用于punchout模式产品同步
        /// </summary>
        [XmlElement("img_storage_type")]
        public string ImgStorageType { get; set; }

        /// <summary>
        /// img_url_list,用于punchout模式产品同步
        /// </summary>
        [XmlArray("img_url_list")]
        [XmlArrayItem("string")]
        public List<string> ImgUrlList { get; set; }

        /// <summary>
        /// mall_url，用于punchout模式产品同步
        /// </summary>
        [XmlElement("mall_url")]
        public string MallUrl { get; set; }

        /// <summary>
        /// oerder_type,用于punchout模式产品同步
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// product_attr_value_list，用于punchout模式产品同步
        /// </summary>
        [XmlArray("product_attr_value_list")]
        [XmlArrayItem("punchout_access_product_attr_value_dto")]
        public List<PunchoutAccessProductAttrValueDto> ProductAttrValueList { get; set; }

        /// <summary>
        /// product_desc，用于punchout模式产品同步
        /// </summary>
        [XmlElement("product_desc")]
        public string ProductDesc { get; set; }

        /// <summary>
        /// product_name，用于punchout模式产品同步
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// purchase_channel,用于punchout模式产品同步
        /// </summary>
        [XmlElement("purchase_channel")]
        public string PurchaseChannel { get; set; }

        /// <summary>
        /// recommendation，用于punchout模式产品同步
        /// </summary>
        [XmlElement("recommendation")]
        public string Recommendation { get; set; }

        /// <summary>
        /// source_category_id，用于punchout模式产品同步
        /// </summary>
        [XmlElement("source_category_id")]
        public string SourceCategoryId { get; set; }

        /// <summary>
        /// source_category_name,用于punchout模式产品同步
        /// </summary>
        [XmlElement("source_category_name")]
        public string SourceCategoryName { get; set; }

        /// <summary>
        /// source_info，用于punchout模式产品同步
        /// </summary>
        [XmlElement("source_info")]
        public string SourceInfo { get; set; }

        /// <summary>
        /// source_type，用于punchout模式产品同步
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// source_value，用于punchout模式产品同步
        /// </summary>
        [XmlElement("source_value")]
        public string SourceValue { get; set; }

        /// <summary>
        /// tenant_id,用于punchout模式产品同步
        /// </summary>
        [XmlElement("tenant_id")]
        public long TenantId { get; set; }

        /// <summary>
        /// unit，用于punchout模式产品同步
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
