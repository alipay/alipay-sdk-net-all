using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftOauthtokenApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftOauthtokenApplyModel : AopObject
    {
        /// <summary>
        /// 授权码，用户对应用授权后得到。为 refresh_token 时不填。
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 授权方式。支持： 1.authorization_code，表示换取使用用户授权码code换取授权令牌access_token。 2.refresh_token，表示使用refresh_token刷新获取新授权令牌。 refresh_token本期新增
        /// </summary>
        [XmlElement("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// 刷新令牌，上次换取访问令牌时得到。
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 请求唯一ID，用于链路跟踪和问题排查
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }
    }
}
