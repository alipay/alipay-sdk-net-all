using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAsiadReceiptCreateResponse.
    /// </summary>
    public class AlipaySecurityProdAsiadReceiptCreateResponse : AopResponse
    {
        /// <summary>
        /// 返回工单id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
