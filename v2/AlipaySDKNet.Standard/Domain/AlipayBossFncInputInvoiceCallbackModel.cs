using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputInvoiceCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputInvoiceCallbackModel : AopObject
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        [XmlElement("input_invoice_callback_open_api_order")]
        public InputInvoiceCallbackOpenApiOrder InputInvoiceCallbackOpenApiOrder { get; set; }
    }
}
