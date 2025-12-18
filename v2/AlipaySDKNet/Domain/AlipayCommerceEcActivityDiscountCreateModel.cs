using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcActivityDiscountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcActivityDiscountCreateModel : AopObject
    {
        /// <summary>
        /// 活动预算信息
        /// </summary>
        [XmlElement("activity_budget_info")]
        public ActivityBudgetInfo ActivityBudgetInfo { get; set; }

        /// <summary>
        /// 人群规则信息
        /// </summary>
        [XmlElement("activity_crowd_info")]
        public ActivityCrowdInfo ActivityCrowdInfo { get; set; }

        /// <summary>
        /// 活动的描述
        /// </summary>
        [XmlElement("activity_description")]
        public string ActivityDescription { get; set; }

        /// <summary>
        /// 活动的名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动优惠信息
        /// </summary>
        [XmlElement("activity_promotion_info")]
        public ActivityPromotionInfo ActivityPromotionInfo { get; set; }

        /// <summary>
        /// 用户使用活动限制规则
        /// </summary>
        [XmlElement("activity_user_usage_limit_info")]
        public ActivityUserUsageLimitInfo ActivityUserUsageLimitInfo { get; set; }

        /// <summary>
        /// 蚂蚁门店id，用于水平权限鉴权。可通过ant.merchant.expand.shop.create创建蚂蚁门店获取
        /// </summary>
        [XmlElement("ant_shop_id")]
        public string AntShopId { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 创建活动的幂等性校验
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
