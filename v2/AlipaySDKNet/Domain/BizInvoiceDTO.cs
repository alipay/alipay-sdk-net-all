using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizInvoiceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BizInvoiceDTO : AopObject
    {
        /// <summary>
        /// 发票金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [XmlElement("excluding_tax_amount")]
        public string ExcludingTaxAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票编号
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 发票链接
        /// </summary>
        [XmlArray("invoice_urls")]
        [XmlArrayItem("string")]
        public List<string> InvoiceUrls { get; set; }

        /// <summary>
        /// 是否红票
        /// </summary>
        [XmlElement("red")]
        public bool Red { get; set; }

        /// <summary>
        /// 含税金额
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }
    }
}
