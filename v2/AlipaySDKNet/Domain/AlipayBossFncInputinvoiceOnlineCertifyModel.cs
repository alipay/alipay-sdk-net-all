using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputinvoiceOnlineCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputinvoiceOnlineCertifyModel : AopObject
    {
        /// <summary>
        /// 勾选入参
        /// </summary>
        [XmlElement("input_invoice_certify_open_api_dto")]
        public InputInvoiceCertifyOpenApiDTO InputInvoiceCertifyOpenApiDto { get; set; }
    }
}
