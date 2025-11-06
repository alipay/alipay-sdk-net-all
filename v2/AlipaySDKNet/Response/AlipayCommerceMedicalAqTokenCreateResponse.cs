using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAqTokenCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalAqTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 授权token开始时间，作为有效期计算的起点
        /// </summary>
        [XmlElement("auth_start")]
        public string AuthStart { get; set; }

        /// <summary>
        /// 访问令牌的有效时间，单位是秒
        /// </summary>
        [XmlElement("expires_in")]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
