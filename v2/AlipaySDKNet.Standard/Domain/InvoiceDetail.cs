using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceDetail Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceDetail : AopObject
    {
        /// <summary>
        /// 产品单位
        /// </summary>
        [XmlElement("measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品型号
        /// </summary>
        [XmlElement("product_specification")]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 单价-元
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 税额-元
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 税额币种
        /// </summary>
        [XmlElement("tax_amount_currency")]
        public string TaxAmountCurrency { get; set; }

        /// <summary>
        /// 不含税金额-元
        /// </summary>
        [XmlElement("tax_exclusive_amount")]
        public string TaxExclusiveAmount { get; set; }

        /// <summary>
        /// 不含税金额币种
        /// </summary>
        [XmlElement("tax_exclusive_amount_currency")]
        public string TaxExclusiveAmountCurrency { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }
    }
}
