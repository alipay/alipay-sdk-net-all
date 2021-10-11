using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponse : AopResponse
    {
        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
