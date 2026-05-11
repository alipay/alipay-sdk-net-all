using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthResult Data Structure.
    /// </summary>
    [Serializable]
    public class AuthResult : AopObject
    {
        /// <summary>
        /// 交换令牌。用于获取用户信息。
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 交换令牌的有效期，单位秒。
        /// </summary>
        [XmlElement("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 刷新令牌有效期,单位秒
        /// </summary>
        [XmlElement("re_expires_in")]
        public string ReExpiresIn { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
