using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdDfesfDefBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdDfesfDefBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ded")]
        public string Ded { get; set; }
    }
}
