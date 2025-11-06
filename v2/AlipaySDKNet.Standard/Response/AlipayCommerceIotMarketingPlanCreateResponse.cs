using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMarketingPlanCreateResponse.
    /// </summary>
    public class AlipayCommerceIotMarketingPlanCreateResponse : AopResponse
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 投放计划状态   WAITTING_AUDIT(0, "WAITTING_AUDIT", "待审核"),     AUDITING(1, "AUDITING", "审核中"),     AUDIT_SUCCESS(2, "AUDIT_SUCCESS", "审核成功"),     AUDIT_FAIL(3, "AUDIT_FAIL", "审核失败"),     ONLINE(4, "ONLINE", "已上线"),     OFFLINE(5, "OFFLINE", "已失效");
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
