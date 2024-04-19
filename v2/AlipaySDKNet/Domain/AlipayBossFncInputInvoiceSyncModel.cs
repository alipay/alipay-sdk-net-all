using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputInvoiceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputInvoiceSyncModel : AopObject
    {
        /// <summary>
        /// 入参
        /// </summary>
        [XmlElement("sync_invoice_open_api_order")]
        public SyncInvoiceOpenApiOrder SyncInvoiceOpenApiOrder { get; set; }
    }
}
