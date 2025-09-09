using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCtocOperatonconfirmOnlineResponse.
    /// </summary>
    public class AnttechNftCtocOperatonconfirmOnlineResponse : AopResponse
    {
        /// <summary>
        /// 验证确认
        /// </summary>
        [XmlElement("verify_confirm_id")]
        public string VerifyConfirmId { get; set; }
    }
}
