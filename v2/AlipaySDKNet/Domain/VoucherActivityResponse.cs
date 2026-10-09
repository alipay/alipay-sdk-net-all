using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherActivityResponse Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherActivityResponse : AopObject
    {
        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("activity_describe")]
        public string ActivityDescribe { get; set; }

        /// <summary>
        /// 活动失效时间
        /// </summary>
        [XmlElement("activity_effective_end_time")]
        public string ActivityEffectiveEndTime { get; set; }

        /// <summary>
        /// 活动生效时间
        /// </summary>
        [XmlElement("activity_effective_start_time")]
        public string ActivityEffectiveStartTime { get; set; }

        /// <summary>
        /// 券活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 券活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 封顶金额，单位元，最多保留两位小数
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 折扣力度，保留一位小数
        /// </summary>
        [XmlElement("promotion_discount")]
        public string PromotionDiscount { get; set; }

        /// <summary>
        /// 优惠可用时间段
        /// </summary>
        [XmlElement("promotion_duration")]
        public PromotionDurationResponse PromotionDuration { get; set; }

        /// <summary>
        /// 限制优惠可用时段
        /// </summary>
        [XmlElement("promotion_limit")]
        public string PromotionLimit { get; set; }

        /// <summary>
        /// 门槛金额，单位元，最多保留两位小数
        /// </summary>
        [XmlElement("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 活动券金额，单位元，最多保留两位小数
        /// </summary>
        [XmlElement("voucher_amount")]
        public string VoucherAmount { get; set; }

        /// <summary>
        /// 券描述
        /// </summary>
        [XmlElement("voucher_describe")]
        public string VoucherDescribe { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
