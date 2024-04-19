using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncInputinvoiceRegisterCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInputinvoiceRegisterCreateModel : AopObject
    {
        /// <summary>
        /// 发票登记入参
        /// </summary>
        [XmlElement("input_invoice_register_open_api_dto")]
        public InputInvoiceRegisterOpenApiDTO InputInvoiceRegisterOpenApiDto { get; set; }
    }
}
