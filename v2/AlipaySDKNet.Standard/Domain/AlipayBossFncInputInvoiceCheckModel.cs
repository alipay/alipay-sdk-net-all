using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputInvoiceCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputInvoiceCheckModel : AopObject
    {
        /// <summary>
        /// 发票验真入参
        /// </summary>
        [XmlElement("invoice_sync_check_dto")]
        public InvoiceSyncCheckDTO InvoiceSyncCheckDto { get; set; }
    }
}
