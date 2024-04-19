using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessGoodsDto Data Structure.
    /// </summary>
    [Serializable]
    public class AccessGoodsDto : AopObject
    {
        /// <summary>
        /// contract_code，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// data_source，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// is_apply_directory_mall，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("is_apply_directory_mall")]
        public string IsApplyDirectoryMall { get; set; }

        /// <summary>
        /// minimum_purchase_quantity，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("minimum_purchase_quantity")]
        public string MinimumPurchaseQuantity { get; set; }

        /// <summary>
        /// quotation_list，用于商品同步，由调用方传入
        /// </summary>
        [XmlArray("quotation_list")]
        [XmlArrayItem("access_quotation_dto")]
        public List<AccessQuotationDto> QuotationList { get; set; }

        /// <summary>
        /// source_value，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("source_value")]
        public string SourceValue { get; set; }

        /// <summary>
        /// supplier_id，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("supplier_id")]
        public long SupplierId { get; set; }

        /// <summary>
        /// 税率，如6%则为6.00
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }
    }
}
