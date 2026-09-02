using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAuthenticationTokenSaveResponse.
    /// </summary>
    public class AlipayUserAuthenticationTokenSaveResponse : AopResponse
    {
        /// <summary>
        /// 认证令牌
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }
    }
}
