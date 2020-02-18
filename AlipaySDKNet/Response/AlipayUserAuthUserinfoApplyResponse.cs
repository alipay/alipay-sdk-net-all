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
        /// 用户的支付宝id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
