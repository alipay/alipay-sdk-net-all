using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityDiscountInfo : AopObject
    {
        /// <summary>
        /// 活动预算信息
        /// </summary>
        [XmlElement("activity_budget_info")]
        public ActivityBudgetInfo ActivityBudgetInfo { get; set; }

        /// <summary>
        /// 活动人群规则信息
        /// </summary>
        [XmlElement("activity_crowd_info")]
        public ActivityCrowdInfo ActivityCrowdInfo { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("activity_description")]
        public string ActivityDescription { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动优惠信息
        /// </summary>
        [XmlElement("activity_promotion_info")]
        public ActivityPromotionInfo ActivityPromotionInfo { get; set; }

        /// <summary>
        /// 用户使用限制信息
        /// </summary>
        [XmlElement("activity_user_usage_limit_info")]
        public ActivityUserUsageLimitInfo ActivityUserUsageLimitInfo { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 创建活动的外部幂等号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 标识活动当前的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
