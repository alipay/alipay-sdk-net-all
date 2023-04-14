using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceLineResponseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceLineResponseDTO : AopObject
    {
        /// <summary>
        /// 含税金额
        /// </summary>
        [XmlElement("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票行id
        /// </summary>
        [XmlElement("invoice_line_id")]
        public string InvoiceLineId { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [XmlElement("measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// 货物或劳务名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("product_specification")]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [XmlElement("tax_exclusive_amt")]
        public MultiCurrencyMoneyOpenApi TaxExclusiveAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [XmlElement("unit_amt")]
        public string UnitAmt { get; set; }
    }
}
