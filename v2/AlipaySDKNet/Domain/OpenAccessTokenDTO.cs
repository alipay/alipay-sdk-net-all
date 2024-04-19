using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenAccessTokenDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenAccessTokenDTO : AopObject
    {
        /// <summary>
        /// 授权令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 刷新令牌
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 刷新令牌有效时间
        /// </summary>
        [XmlElement("refresh_token_expire_time")]
        public string RefreshTokenExpireTime { get; set; }
    }
}
