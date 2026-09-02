using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpAgentCreateResponse.
    /// </summary>
    public class AlipayOpenSpAgentCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
