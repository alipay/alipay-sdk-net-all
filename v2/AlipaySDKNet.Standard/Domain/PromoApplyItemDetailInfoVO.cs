using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoApplyItemDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoApplyItemDetailInfoVO : AopObject
    {
        /// <summary>
        /// 优惠申领金额或者数量，金额时单位为分
        /// </summary>
        [XmlElement("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 优惠申领的预算类型
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 会员等级
        /// </summary>
        [XmlElement("member_level")]
        public string MemberLevel { get; set; }

        /// <summary>
        /// 营销优惠子类型
        /// </summary>
        [XmlElement("promotion_sub_type")]
        public string PromotionSubType { get; set; }

        /// <summary>
        /// 营销优惠类型
        /// </summary>
        [XmlElement("promotion_type")]
        public string PromotionType { get; set; }
    }
}
