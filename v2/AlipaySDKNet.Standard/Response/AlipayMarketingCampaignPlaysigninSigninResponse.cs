using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPlaysigninSigninResponse.
    /// </summary>
    public class AlipayMarketingCampaignPlaysigninSigninResponse : AopResponse
    {
        /// <summary>
        /// 签到发奖流水
        /// </summary>
        [XmlArray("prize_send_list")]
        [XmlArrayItem("prize_send_info")]
        public List<PrizeSendInfo> PrizeSendList { get; set; }

        /// <summary>
        /// 签到的错误码描述
        /// </summary>
        [XmlElement("trigger_error_code")]
        public string TriggerErrorCode { get; set; }

        /// <summary>
        /// 签到失败的说明
        /// </summary>
        [XmlElement("trigger_error_message")]
        public string TriggerErrorMessage { get; set; }

        /// <summary>
        /// true触发成功，false触发失败
        /// </summary>
        [XmlElement("trigger_result")]
        public bool TriggerResult { get; set; }
    }
}
