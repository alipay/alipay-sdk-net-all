using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceMainInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceMainInfo : AopObject
    {
        /// <summary>
        /// 0 个人，1 企业
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 本次不含税总金额，单位元精确到分
        /// </summary>
        [XmlElement("excluding_tax_amount")]
        public string ExcludingTaxAmount { get; set; }

        /// <summary>
        /// 本次含税开票或红冲总金额；红票由商户按正数传入，单位元精确到分
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 81 数电专用增值税发票，82 数电普通发票
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 1 蓝票，2 红票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 本次总税额，单位元精确到分
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }
    }
}
