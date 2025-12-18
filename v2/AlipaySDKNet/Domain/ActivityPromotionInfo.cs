using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityPromotionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityPromotionInfo : AopObject
    {
        /// <summary>
        /// 优惠时间限制信息，可限制周和天的使用时间段
        /// </summary>
        [XmlElement("activity_promotion_duration")]
        public ActivityPromotionDuration ActivityPromotionDuration { get; set; }

        /// <summary>
        /// 最高优惠金额，单位元；当promotion_type为VERTICAL_SUBTRACTION时，最高优惠金额要大于立减金额;当promotion_type为DISCOUNT时，最高优惠金额要大于0;
        /// </summary>
        [XmlElement("ceil_promotion_amount")]
        public string CeilPromotionAmount { get; set; }

        /// <summary>
        /// 表示单笔减或者满减金额，单位元；
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 表示优惠类型为折扣优惠时折扣的比例，通过小数表示如8.8表示88折。值的范围[1,9.99]
        /// </summary>
        [XmlElement("discount_ratio")]
        public string DiscountRatio { get; set; }

        /// <summary>
        /// 支持使用优惠的产品类型，固定枚举值
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 支持选择的优惠类型，固定枚举值
        /// </summary>
        [XmlElement("promotion_type")]
        public string PromotionType { get; set; }

        /// <summary>
        /// 立减门槛金额，单位元；当promotion_type=SINGLE_DEDUCTION时，单笔减的门槛金额>0；当promotion_type=VERTICAL_SUBTRACTION时，每满金额<10000
        /// </summary>
        [XmlElement("threshold_amount")]
        public string ThresholdAmount { get; set; }
    }
}
