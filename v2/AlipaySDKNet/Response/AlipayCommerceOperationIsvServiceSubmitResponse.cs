using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationIsvServiceSubmitResponse.
    /// </summary>
    public class AlipayCommerceOperationIsvServiceSubmitResponse : AopResponse
    {
        /// <summary>
        /// id （后续消息标识对应服务）
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
