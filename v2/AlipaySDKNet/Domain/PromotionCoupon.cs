using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromotionCoupon Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionCoupon : AopObject
    {
        /// <summary>
        /// 折扣10元金额 单位分
        /// </summary>
        [XmlElement("amount_off")]
        public long AmountOff { get; set; }

        /// <summary>
        /// 优惠编码
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 周期性重复类型 支持 forever（永久）、once（一次性）、repeating（重复）模式
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 在接下来的3个计费周期可重复使用该优惠
        /// </summary>
        [XmlElement("duration_in_iterations")]
        public string DurationInIterations { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 折扣比例，百分比，10%含义为9折
        /// </summary>
        [XmlElement("percent_off")]
        public long PercentOff { get; set; }

        /// <summary>
        /// 优惠到期时间
        /// </summary>
        [XmlElement("redeem_by")]
        public string RedeemBy { get; set; }
    }
}
