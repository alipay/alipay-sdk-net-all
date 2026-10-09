using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceCheckLine Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceCheckLine : AopObject
    {
        /// <summary>
        /// 含税金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Y:免税
        /// </summary>
        [XmlElement("duty_free_flag")]
        public string DutyFreeFlag { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [XmlElement("measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// 货物名称
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
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [XmlElement("tax_exclusive_amt")]
        public string TaxExclusiveAmt { get; set; }

        /// <summary>
        /// 税率,两位小数
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
