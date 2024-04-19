using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignRecruitEnrollCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignRecruitEnrollCreateModel : AopObject
    {
        /// <summary>
        /// 活动报名基本信息。
        /// </summary>
        [XmlElement("enroll_base_info")]
        public RecruitEnrollBaseInfo EnrollBaseInfo { get; set; }

        /// <summary>
        /// 活动报名内容。 包含报名提交的核心内容信息。
        /// </summary>
        [XmlElement("enroll_content")]
        public RecruitEnrollContent EnrollContent { get; set; }

        /// <summary>
        /// 活动报名素材。
        /// </summary>
        [XmlElement("enroll_material")]
        public RecruitEnrollMaterial EnrollMaterial { get; set; }

        /// <summary>
        /// 外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 定向信息。
        /// </summary>
        [XmlElement("serving_target")]
        public RecruitServingTarget ServingTarget { get; set; }
    }
}
