using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstancecomponentCertifyResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateInstancecomponentCertifyResponse : AopResponse
    {
        /// <summary>
        /// refreshToken
        /// </summary>
        [XmlElement("al_refresh_token")]
        public string AlRefreshToken { get; set; }

        /// <summary>
        /// refreshToken过期时间
        /// </summary>
        [XmlElement("al_refresh_token_expire")]
        public string AlRefreshTokenExpire { get; set; }

        /// <summary>
        /// token
        /// </summary>
        [XmlElement("al_token")]
        public string AlToken { get; set; }

        /// <summary>
        /// token有效期
        /// </summary>
        [XmlElement("al_token_expire")]
        public long AlTokenExpire { get; set; }
    }
}
