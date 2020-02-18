using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntpaasTokenThirdTrustLoginResponse.
    /// </summary>
    public class AlipayUserAntpaasTokenThirdTrustLoginResponse : AopResponse
    {
        /// <summary>
        /// third_trust_token：用户免登的一次性token；后续使用改token进行免登请求。
        /// </summary>
        [XmlElement("third_trust_token")]
        public string ThirdTrustToken { get; set; }
    }
}
