using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSealAuthResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignSealAuthResponse : AopResponse
    {
        /// <summary>
        /// 授权跳转链接
        /// </summary>
        [XmlElement("auth_jump_url")]
        public string AuthJumpUrl { get; set; }
    }
}
