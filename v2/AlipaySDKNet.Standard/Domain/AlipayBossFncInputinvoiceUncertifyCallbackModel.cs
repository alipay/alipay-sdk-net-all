using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputinvoiceUncertifyCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputinvoiceUncertifyCallbackModel : AopObject
    {
        /// <summary>
        /// 反勾选回调入参
        /// </summary>
        [XmlElement("input_invoice_callback_open_api_dto")]
        public InputInvoiceCallbackOpenApiDTO InputInvoiceCallbackOpenApiDto { get; set; }
    }
}
