using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SyncInvoiceResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SyncInvoiceResponse : AopObject
    {
        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
