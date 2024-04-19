using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceOrderRequest Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceOrderRequest : AopObject
    {
        /// <summary>
        /// 购方机构OU
        /// </summary>
        [XmlElement("buyer_inst_id")]
        public string BuyerInstId { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 不含税金额-元
        /// </summary>
        [XmlElement("exclude_tax_invoice_amt")]
        public string ExcludeTaxInvoiceAmt { get; set; }

        /// <summary>
        /// 票面金额-元
        /// </summary>
        [XmlElement("invoice_amt")]
        public string InvoiceAmt { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期 格式(yyyyMMdd)
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票介质 01-电子 02-纸质
        /// </summary>
        [XmlElement("invoice_material")]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 收票日期 格式(yyyyMMdd)
        /// </summary>
        [XmlElement("invoice_receive_date")]
        public string InvoiceReceiveDate { get; set; }

        /// <summary>
        /// 发票录入来源  04:集采录入
        /// </summary>
        [XmlElement("invoice_source")]
        public string InvoiceSource { get; set; }

        /// <summary>
        /// 发票种类 01增值税专用发票 02增值税普通发票 03国际形式发票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 关联的单据号
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 业务单号类型
        /// </summary>
        [XmlElement("out_bill_type")]
        public string OutBillType { get; set; }

        /// <summary>
        /// 账单关联发票金额-元
        /// </summary>
        [XmlElement("relate_amount")]
        public string RelateAmount { get; set; }

        /// <summary>
        /// 关联到账单上的税额-元
        /// </summary>
        [XmlElement("relate_tax_amt")]
        public string RelateTaxAmt { get; set; }

        /// <summary>
        /// 销方角色2088账号pid
        /// </summary>
        [XmlElement("seller_ip_role_id")]
        public string SellerIpRoleId { get; set; }

        /// <summary>
        /// 系统来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 票面税额-元
        /// </summary>
        [XmlElement("tax_amt")]
        public string TaxAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }
    }
}
