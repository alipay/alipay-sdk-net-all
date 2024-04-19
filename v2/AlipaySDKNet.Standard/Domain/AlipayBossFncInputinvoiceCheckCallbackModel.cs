using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputinvoiceCheckCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputinvoiceCheckCallbackModel : AopObject
    {
        /// <summary>
        /// 验真回调入参
        /// </summary>
        [XmlElement("input_invoice_callback_open_api_dto")]
        public InputInvoiceCallbackOpenApiDTO InputInvoiceCallbackOpenApiDto { get; set; }
    }
}
