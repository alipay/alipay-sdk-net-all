using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskReconfirmVerificatecallbackSendResponse.
    /// </summary>
    public class AlipaySecurityRiskReconfirmVerificatecallbackSendResponse : AopResponse
    {
        /// <summary>
        /// 额外返回信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }
    }
}
