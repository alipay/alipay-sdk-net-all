using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardCreatePrepaidPromotionPlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardCreatePrepaidPromotionPlanInfo : AopObject
    {
        /// <summary>
        /// 充值方案权益金部分，单位是元，且必须是整数，最小为0，权益金不超过5000元
        /// </summary>
        [XmlElement("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 储值方案对应赠送券信息
        /// </summary>
        [XmlArray("benefit_voucher_list")]
        [XmlArrayItem("member_card_voucher_benefit_info")]
        public List<MemberCardVoucherBenefitInfo> BenefitVoucherList { get; set; }

        /// <summary>
        /// 方案的失效时间，如果不传，则为默认值：2037-12-31 23:59:59
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 充值本金部分，单位是元，且必须是整数，必须大于0，本金不超过5000元
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 新增的话不需要传；如果是修改需要传入
        /// </summary>
        [XmlElement("promotion_plan_id")]
        public string PromotionPlanId { get; set; }

        /// <summary>
        /// 充值方案总次数限制
        /// </summary>
        [XmlElement("publish_total_num")]
        public long PublishTotalNum { get; set; }

        /// <summary>
        /// 方案开始生效时间, 如果不传默认当前时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 正常不需要传，忽略
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
