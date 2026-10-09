using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingRecruitEnrollQueryModel : AopObject
    {
        /// <summary>
        /// 报名ID，此参数和out_biz_no至少传一个，优先取enroll_id
        /// </summary>
        [XmlElement("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 外部操作流水号，创建招商报名时传入。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
