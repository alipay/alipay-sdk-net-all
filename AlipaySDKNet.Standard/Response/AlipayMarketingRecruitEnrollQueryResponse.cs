using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollQueryResponse.
    /// </summary>
    public class AlipayMarketingRecruitEnrollQueryResponse : AopResponse
    {
        /// <summary>
        /// 报名ID
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 报名信息
        /// </summary>
        [XmlElement("enroll_info")]
        public RecruitEnrollInfo EnrollInfo { get; set; }

        /// <summary>
        /// 报名所属的活动报名场景。 枚举值： VOUCHER：属于券报名场景； MINI_APP：属于小程序报名场景；
        /// </summary>
        [XmlElement("enroll_scene_type")]
        public string EnrollSceneType { get; set; }

        /// <summary>
        /// 报名时间
        /// </summary>
        [XmlElement("enroll_time")]
        public string EnrollTime { get; set; }

        /// <summary>
        /// 备注字段
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 招商方案ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 报名状态： AUDITING 审核中； ENABLED 通过 ； REJECTED 不通过 ； CLOSING 下线审核中 ； CLOSED 已下线；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
