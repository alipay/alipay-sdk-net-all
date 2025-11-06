using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDrivercertQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiDrivercertQueryResponse : AopResponse
    {
        /// <summary>
        /// 认证成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
