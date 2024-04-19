using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayApplepayTransactionauthtokenCreateResponse.
    /// </summary>
    public class AlipayPayApplepayTransactionauthtokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 通知authToken
        /// </summary>
        [XmlElement("authentication_token")]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// 响应报文头部
        /// </summary>
        [XmlElement("response_header")]
        public BaseOpenApiResponseHeaderDTO ResponseHeader { get; set; }

        /// <summary>
        /// 是否允许通知状态转移
        /// </summary>
        [XmlElement("supports_settlement")]
        public bool SupportsSettlement { get; set; }
    }
}
