using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingRecruitEnrollCreateModel : AopObject
    {
        /// <summary>
        /// 报名信息
        /// </summary>
        [XmlElement("enroll_info")]
        public RecruitEnrollInfo EnrollInfo { get; set; }

        /// <summary>
        /// 外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 要报名的招商方案ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
