using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneOpenprodPermissionAuthResponse.
    /// </summary>
    public class AlipayInsSceneOpenprodPermissionAuthResponse : AopResponse
    {
        /// <summary>
        /// token
        /// </summary>
        [XmlElement("auth_token")]
        public string AuthToken { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expiration")]
        public string Expiration { get; set; }
    }
}
