using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoicingNoAndDate Data Structure.
    /// </summary>
    [Serializable]
    public class InvoicingNoAndDate : AopObject
    {
        /// <summary>
        /// 发票号
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [XmlElement("invoicing_date")]
        public string InvoicingDate { get; set; }
    }
}
