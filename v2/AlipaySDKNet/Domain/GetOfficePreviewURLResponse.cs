using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GetOfficePreviewURLResponse Data Structure.
    /// </summary>
    [Serializable]
    public class GetOfficePreviewURLResponse : AopObject
    {
        /// <summary>
        /// ak
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// ak有效期
        /// </summary>
        [XmlElement("access_token_expired_time")]
        public string AccessTokenExpiredTime { get; set; }

        /// <summary>
        /// 预览地址
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 刷新token
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 刷新token有效期
        /// </summary>
        [XmlElement("refresh_token_expired_time")]
        public string RefreshTokenExpiredTime { get; set; }

        /// <summary>
        /// 请求号
        /// </summary>
        [XmlElement("request_d")]
        public string RequestD { get; set; }
    }
}
