using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundEnterprisepayMemberjointurlApplyResponse.
    /// </summary>
    public class AlipayFundEnterprisepayMemberjointurlApplyResponse : AopResponse
    {
        /// <summary>
        /// 邀请员工二维码链接（包含token信息）
        /// </summary>
        [XmlElement("apply_url")]
        public string ApplyUrl { get; set; }

        /// <summary>
        /// 邀请员工二维码链接的token，后续根据token进行校验
        /// </summary>
        [XmlElement("apply_url_token")]
        public string ApplyUrlToken { get; set; }

        /// <summary>
        /// 到期时间，小于等于到期时间的都有效
        /// </summary>
        [XmlElement("expiration_time")]
        public string ExpirationTime { get; set; }
    }
}
