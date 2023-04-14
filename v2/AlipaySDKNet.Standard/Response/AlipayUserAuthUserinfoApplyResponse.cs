using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAuthUserinfoApplyResponse.
    /// </summary>
    public class AlipayUserAuthUserinfoApplyResponse : AopResponse
    {
        /// <summary>
        /// 授权的码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 用户在应用（AppId）下的用户唯一标识。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户的支付宝id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
