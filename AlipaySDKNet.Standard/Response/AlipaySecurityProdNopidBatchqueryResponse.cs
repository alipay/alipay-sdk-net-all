using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdNopidBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdNopidBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("rthreemcc")]
        public string Rthreemcc { get; set; }
    }
}
