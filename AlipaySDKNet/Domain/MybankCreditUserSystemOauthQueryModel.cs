using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditUserSystemOauthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditUserSystemOauthQueryModel : AopObject
    {
        /// <summary>
        /// 授权码，用户对应用授权后得到。
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 值为authorization_code时，代表用code换取；值为refresh_token时，代表用refresh_token换取
        /// </summary>
        [XmlElement("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// 刷新令牌，上次换取访问令牌时得到。见出参的refresh_token字段
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
