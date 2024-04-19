using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignRecruitEnrollQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignRecruitEnrollQueryModel : AopObject
    {
        /// <summary>
        /// 活动报名ID。 创建活动报名时返回的 enroll_id。
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 外部操作流水号，创建活动报名时传入。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
