using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardPrepaidPromotionPlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardPrepaidPromotionPlanInfo : AopObject
    {
        /// <summary>
        /// 储值方案权益金部分
        /// </summary>
        [XmlElement("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 储值方案赠送优惠券信息
        /// </summary>
        [XmlElement("benefit_voucher_list")]
        public MemberCardVoucherBenefitInfo BenefitVoucherList { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 储值方案结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 储值方案本金部分
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 优惠方案的ID
        /// </summary>
        [XmlElement("promotion_plan_id")]
        public string PromotionPlanId { get; set; }

        /// <summary>
        /// 充值方案总次数限制
        /// </summary>
        [XmlElement("publish_total_num")]
        public long PublishTotalNum { get; set; }

        /// <summary>
        /// 充值方案剩余次数
        /// </summary>
        [XmlElement("publish_total_remain_num")]
        public string PublishTotalRemainNum { get; set; }

        /// <summary>
        /// 储值方案开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 储值方案的状态，ENABLED(启用), DISABLED(停用)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
