using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterRegisterCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceTopregisterRegisterCreateResponse : AopResponse
    {
        /// <summary>
        /// 工单ID
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }
    }
}
