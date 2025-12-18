using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationCarservicesaastldcAuthenticationQuerystatusResponse.
    /// </summary>
    public class AlipayCommerceOperationCarservicesaastldcAuthenticationQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 身份认证编号
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// SUCCESS代表可信，FAIL代表不可信，AUTHING代表未知需要等待结果
        /// </summary>
        [XmlElement("auth_result")]
        public string AuthResult { get; set; }

        /// <summary>
        /// 身份认证类型
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }
    }
}
