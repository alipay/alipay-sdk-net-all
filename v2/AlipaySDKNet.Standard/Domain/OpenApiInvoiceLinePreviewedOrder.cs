using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiInvoiceLinePreviewedOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiInvoiceLinePreviewedOrder : AopObject
    {
        /// <summary>
        /// 发票的票面金额
        /// </summary>
        [XmlElement("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 用于标识该发票是否为免税发票，Y代表免税发票，N代表非免税发票
        /// </summary>
        [XmlElement("duty_free_flag")]
        public string DutyFreeFlag { get; set; }

        /// <summary>
        /// 发票的免税类型，当免税标识为Y时，需要传入该字段
        /// </summary>
        [XmlElement("duty_free_type")]
        public string DutyFreeType { get; set; }

        /// <summary>
        /// 发票行对应的发票标识，标识改发票行对应的发票是哪一张
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票行在表中的唯一标识（主键），用于标识具体的发票中具体的一行发票行
        /// </summary>
        [XmlElement("invoice_line_id")]
        public string InvoiceLineId { get; set; }

        /// <summary>
        /// 发票行上，标识货物单位的字段
        /// </summary>
        [XmlElement("measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// 发票行中，用于标识具体货物或劳务名称的字段
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 劳务与货物名称的后缀，主要有账期（202309）、PID（2088XXXX）等
        /// </summary>
        [XmlElement("product_name_suffix")]
        public string ProductNameSuffix { get; set; }

        /// <summary>
        /// 发票行商的规格型号字段
        /// </summary>
        [XmlElement("product_specification")]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// 发票行中标识货物数量的字段
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 发票票面的税额
        /// </summary>
        [XmlElement("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 税收分类编码是指税务总局编制的用于开具发票“货物或应税劳务、服务名称”项目时统一使用的分类与编码体系
        /// </summary>
        [XmlElement("tax_classification_code")]
        public string TaxClassificationCode { get; set; }

        /// <summary>
        /// 发票票面的不含税金额
        /// </summary>
        [XmlElement("tax_exclusive_amt")]
        public MultiCurrencyMoneyOpenApi TaxExclusiveAmt { get; set; }

        /// <summary>
        /// 发票行税率，标识对应货物的税金征收率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 税种标识，1：营业税，2：增值税等
        /// </summary>
        [XmlElement("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 租户，标识站点
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 发票行中，标识获取单价的字段
        /// </summary>
        [XmlElement("unit_amt")]
        public string UnitAmt { get; set; }
    }
}
