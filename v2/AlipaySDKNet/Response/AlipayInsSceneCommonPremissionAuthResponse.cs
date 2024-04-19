using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCommonPremissionAuthResponse.
    /// </summary>
    public class AlipayInsSceneCommonPremissionAuthResponse : AopResponse
    {
        /// <summary>
        /// 授权token
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expiration")]
        public string Expiration { get; set; }
    }
}
