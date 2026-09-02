using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryReferralApplySendResponse.
    /// </summary>
    public class AlipayEbppIndustryReferralApplySendResponse : AopResponse
    {
        /// <summary>
        /// 推荐结果是否已被受理并进入候选人录入及短信确认流程
        /// </summary>
        [XmlElement("accepted")]
        public bool Accepted { get; set; }

        /// <summary>
        /// 拒绝录入原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
