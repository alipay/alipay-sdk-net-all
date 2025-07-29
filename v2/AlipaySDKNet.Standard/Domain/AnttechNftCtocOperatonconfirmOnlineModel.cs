using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCtocOperatonconfirmOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCtocOperatonconfirmOnlineModel : AopObject
    {
        /// <summary>
        /// 短信验证码
        /// </summary>
        [XmlElement("confirm_code")]
        public string ConfirmCode { get; set; }

        /// <summary>
        /// 认证事件id
        /// </summary>
        [XmlElement("verify_event_id")]
        public string VerifyEventId { get; set; }
    }
}
