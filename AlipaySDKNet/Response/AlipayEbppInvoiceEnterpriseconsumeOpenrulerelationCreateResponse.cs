using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
