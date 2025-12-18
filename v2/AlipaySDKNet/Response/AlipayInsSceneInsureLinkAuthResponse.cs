using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsureLinkAuthResponse.
    /// </summary>
    public class AlipayInsSceneInsureLinkAuthResponse : AopResponse
    {
        /// <summary>
        /// authed_token
        /// </summary>
        [XmlElement("authed_token")]
        public string AuthedToken { get; set; }

        /// <summary>
        /// 过期时间（s）
        /// </summary>
        [XmlElement("expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// 投保url
        /// </summary>
        [XmlElement("insure_url")]
        public string InsureUrl { get; set; }
    }
}
