using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputinvoiceDistributeCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputinvoiceDistributeCallbackModel : AopObject
    {
        /// <summary>
        /// 回调入参
        /// </summary>
        [XmlElement("input_invoice_callback_open_api_dto")]
        public InputInvoiceCallbackOpenApiDTO InputInvoiceCallbackOpenApiDto { get; set; }
    }
}
