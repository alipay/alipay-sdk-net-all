using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceLineOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceLineOpenApiDTO : AopObject
    {
        /// <summary>
        /// 含税金额,币种单位见currency字段
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 不含税金额,币种单位见currency字段
        /// </summary>
        [XmlElement("excluding_tax_amount")]
        public string ExcludingTaxAmount { get; set; }

        /// <summary>
        /// 货物名称
        /// </summary>
        [XmlElement("goods_desc")]
        public string GoodsDesc { get; set; }

        /// <summary>
        /// 发票行id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public long InvoiceId { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("model")]
        public string Model { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("quantity_unit")]
        public string QuantityUnit { get; set; }

        /// <summary>
        /// 税额,币种单位见currency字段
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 税种
        /// </summary>
        [XmlElement("tax_categories")]
        public string TaxCategories { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [XmlElement("unit_price")]
        public long UnitPrice { get; set; }
    }
}
