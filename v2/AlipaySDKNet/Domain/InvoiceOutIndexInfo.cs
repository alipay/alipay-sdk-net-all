using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceOutIndexInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceOutIndexInfo : AopObject
    {
        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票外部索引号
        /// </summary>
        [XmlElement("invoice_out_no")]
        public string InvoiceOutNo { get; set; }
    }
}
