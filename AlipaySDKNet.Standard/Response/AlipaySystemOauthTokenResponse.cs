using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySystemOauthTokenResponse.
    /// </summary>
    public class AlipaySystemOauthTokenResponse : AopResponse
    {
        /// <summary>
        /// 访问令牌。通过该令牌调用需要授权类接口
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 已废弃，请勿使用
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 授权token开始时间，作为有效期计算的起点
        /// </summary>
        [XmlElement("auth_start")]
        public string AuthStart { get; set; }

        /// <summary>
        /// 令牌类型，permanent表示返回的access_token和refresh_token永久有效，非永久令牌不返回该字段
        /// </summary>
        [XmlElement("auth_token_type")]
        public string AuthTokenType { get; set; }

        /// <summary>
        /// 访问令牌的有效时间，单位是秒。
        /// </summary>
        [XmlElement("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 支付宝用户唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 刷新令牌的有效时间，单位是秒。
        /// </summary>
        [XmlElement("re_expires_in")]
        public string ReExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌。通过该令牌可以刷新access_token
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// union_id是支付宝用户在开放平台的唯一标识符，在配置应用分组后会返回该值。 同一用户的union_id在同一分组内应用的union_id一致。
        /// </summary>
        [XmlElement("union_id")]
        public string UnionId { get; set; }

        /// <summary>
        /// 支付宝用户的唯一标识。以2088开头的16位数字。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
