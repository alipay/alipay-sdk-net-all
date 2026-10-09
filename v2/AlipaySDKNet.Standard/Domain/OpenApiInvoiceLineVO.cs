using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiInvoiceLineVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiInvoiceLineVO : AopObject
    {
        /// <summary>
        /// 含税金额
        /// </summary>
        [XmlElement("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 免税标识
        /// </summary>
        [XmlElement("duty_free_flag")]
        public string DutyFreeFlag { get; set; }

        /// <summary>
        /// 免税类型，当为免税时此字段应该有值见ArInvoiceDutyFreeTypeEnum枚举
        /// </summary>
        [XmlElement("duty_free_type")]
        public string DutyFreeType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票行唯一id
        /// </summary>
        [XmlElement("invoice_line_id")]
        public string InvoiceLineId { get; set; }

        /// <summary>
        /// 最后一次修改人
        /// </summary>
        [XmlElement("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [XmlElement("measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// 软件服务费
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 货物或劳务名称后缀
        /// </summary>
        [XmlElement("product_name_suffix")]
        public string ProductNameSuffix { get; set; }

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
        /// 税收分类编码
        /// </summary>
        [XmlElement("tax_classification_code")]
        public string TaxClassificationCode { get; set; }

        /// <summary>
        /// 税收分类简称
        /// </summary>
        [XmlElement("tax_classification_short_name")]
        public string TaxClassificationShortName { get; set; }

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
        /// 租户机构id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [XmlElement("unit_amt")]
        public string UnitAmt { get; set; }
    }
}
