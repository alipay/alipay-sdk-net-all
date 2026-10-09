using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PunchoutOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class PunchoutOrderItem : AopObject
    {
        /// <summary>
        /// 合同id，用于下pr单
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// currency_code，用于下pr单
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// item_description，用于下pr单
        /// </summary>
        [XmlElement("item_description")]
        public string ItemDescription { get; set; }

        /// <summary>
        /// 商品id，用于下pr单
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// item_name
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// mall_category_id，用于下pr单
        /// </summary>
        [XmlElement("mall_category_id")]
        public string MallCategoryId { get; set; }

        /// <summary>
        /// quantity，用于下pr单
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// sku_id，用于下pr单
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sub_pur_req_id，用于下pr单
        /// </summary>
        [XmlElement("sub_pur_req_id")]
        public string SubPurReqId { get; set; }

        /// <summary>
        /// 供应商id用于下pr单
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 税率，如13%传13
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 单价（含税），用于pr下单
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// uom，用于下pr单
        /// </summary>
        [XmlElement("uom")]
        public string Uom { get; set; }
    }
}
