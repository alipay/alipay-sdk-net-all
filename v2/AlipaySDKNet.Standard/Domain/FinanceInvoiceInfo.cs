using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinanceInvoiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FinanceInvoiceInfo : AopObject
    {
        /// <summary>
        /// 发票金额（不含税），以元为单位的，精确到小数点后2位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 发票金额（含税）
        /// </summary>
        [XmlElement("amount_with_tax")]
        public string AmountWithTax { get; set; }

        /// <summary>
        /// UTC标准格式
        /// </summary>
        [XmlElement("billing_date")]
        public string BillingDate { get; set; }

        /// <summary>
        /// 发票验证码后6位
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 发票对应合同编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 发票影印件信息
        /// </summary>
        [XmlElement("file")]
        public FinanceFileInfo File { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_number")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// 发票类型:专票SPECIAL,普票REGULAR,电票DIGITAL
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }
    }
}
