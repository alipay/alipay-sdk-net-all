using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPlaysigninSignupResponse.
    /// </summary>
    public class AlipayMarketingCampaignPlaysigninSignupResponse : AopResponse
    {
        /// <summary>
        /// 签到报名错误码
        /// </summary>
        [XmlElement("trigger_error_code")]
        public string TriggerErrorCode { get; set; }

        /// <summary>
        /// 对于签到报名失败的说明
        /// </summary>
        [XmlElement("trigger_error_message")]
        public string TriggerErrorMessage { get; set; }

        /// <summary>
        /// true:签到报名触发成功 false:签到报名触发失败
        /// </summary>
        [XmlElement("trigger_result")]
        public bool TriggerResult { get; set; }
    }
}
