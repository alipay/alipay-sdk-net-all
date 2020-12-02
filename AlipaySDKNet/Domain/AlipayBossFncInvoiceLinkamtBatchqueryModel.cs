using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceLinkamtBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoiceLinkamtBatchqueryModel : AopObject
    {
        /// <summary>
        /// 发票ID，唯一性ID，发票表唯一主键ID
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
