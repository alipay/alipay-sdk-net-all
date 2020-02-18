using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationInitializeResponse.
    /// </summary>
    public class AlipaySecurityRiskAuthenticationInitializeResponse : AopResponse
    {
        /// <summary>
        /// 身份安全业务初始化后返回的业务信息
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 身份安全业务初始化后生成的token
        /// </summary>
        [XmlElement("token_id")]
        public string TokenId { get; set; }
    }
}
