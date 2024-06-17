using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefreshWebofficeTokenResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RefreshWebofficeTokenResponse : AopObject
    {
        /// <summary>
        /// ak
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// ak过期时间
        /// </summary>
        [XmlElement("access_token_expired_time")]
        public string AccessTokenExpiredTime { get; set; }

        /// <summary>
        /// 刷新token
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 刷新token失效时间
        /// </summary>
        [XmlElement("refresh_token_expired_time")]
        public string RefreshTokenExpiredTime { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
