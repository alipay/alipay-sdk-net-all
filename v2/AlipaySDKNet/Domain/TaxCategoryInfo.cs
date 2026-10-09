using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaxCategoryInfo : AopObject
    {
        /// <summary>
        /// 参考征收率信息
        /// </summary>
        [XmlArray("collection_rate")]
        [XmlArrayItem("rate_info")]
        public List<RateInfo> CollectionRate { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品服务分类简称
        /// </summary>
        [XmlElement("item_category_name")]
        public string ItemCategoryName { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 父级税编
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }

        /// <summary>
        /// 特定要素标签
        /// </summary>
        [XmlElement("specific_element_tag")]
        public string SpecificElementTag { get; set; }

        /// <summary>
        /// 商品税收分类编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// 参考增值税税率信息
        /// </summary>
        [XmlArray("vat_rate")]
        [XmlArrayItem("rate_info")]
        public List<RateInfo> VatRate { get; set; }
    }
}
