using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundScenepayAuthorizeQueryResponse.
    /// </summary>
    public class AlipayFundScenepayAuthorizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权ID
        /// </summary>
        [XmlElement("authorization_id")]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// NORMAL 正常状态 UNSIGN 未签约或已解约
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
