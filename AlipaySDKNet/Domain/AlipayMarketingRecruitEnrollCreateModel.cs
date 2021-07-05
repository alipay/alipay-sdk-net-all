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
        /// 外部业务号
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
