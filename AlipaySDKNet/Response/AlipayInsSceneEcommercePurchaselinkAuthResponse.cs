using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchaselinkAuthResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePurchaselinkAuthResponse : AopResponse
    {
        /// <summary>
        /// 授权token
        /// </summary>
        [XmlElement("authed_token")]
        public string AuthedToken { get; set; }

        /// <summary>
        /// 已授权的订购url
        /// </summary>
        [XmlElement("authed_url")]
        public string AuthedUrl { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expiration")]
        public string Expiration { get; set; }
    }
}
