using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorOauthCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalHomedoctorOauthCreateResponse : AopResponse
    {
        /// <summary>
        /// AQ访问令牌。通过该令牌调用需要授权类接口
        /// </summary>
        [XmlElement("aq_access_token")]
        public string AqAccessToken { get; set; }

        /// <summary>
        /// 用户对外开放openid
        /// </summary>
        [XmlElement("aq_open_id")]
        public string AqOpenId { get; set; }

        /// <summary>
        /// 访问令牌的有效时间，单位是秒。
        /// </summary>
        [XmlElement("expires_in")]
        public string ExpiresIn { get; set; }
    }
}
