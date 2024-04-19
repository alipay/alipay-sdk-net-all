using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRecruitEnrollCloseResponse.
    /// </summary>
    public class AlipayMarketingCampaignRecruitEnrollCloseResponse : AopResponse
    {
        /// <summary>
        /// 本次下线操作的目标报名ID。
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 报名状态。 下线操作响应的状态枚举值只有三种情况： CLOSE_AUDITING 下线审核中，下线结果请等待后续状态变更通知，或主动查询活动报名详情 ；  CLOSED 已下线； REJECTED 不通过，无需下线；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
