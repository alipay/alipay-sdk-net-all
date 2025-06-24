using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReimburseInvoice Data Structure.
    /// </summary>
    [Serializable]
    public class ReimburseInvoice : AopObject
    {
        /// <summary>
        /// 发票代码，数电票中没有发票代码。传统税控票中发票代码通常12位
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码，不可为空。通常传统税控票通常发票号码为8位，数电票发票号码为20位
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }
    }
}
