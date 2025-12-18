using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAutologinTokenCreateResponse.
    /// </summary>
    public class AlipayCommerceEcAutologinTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 令牌
        /// </summary>
        [XmlElement("auto_login_token")]
        public string AutoLoginToken { get; set; }
    }
}
