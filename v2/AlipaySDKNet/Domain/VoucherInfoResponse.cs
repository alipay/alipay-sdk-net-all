using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherInfoResponse : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 券发行方名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 封顶金额，单位元，最多保留两位小数
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 折扣力度，最多保留一位小数
        /// </summary>
        [XmlElement("promotion_discount")]
        public string PromotionDiscount { get; set; }

        /// <summary>
        /// 优惠可用时段
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
        /// 券面额，单位元，最多保留两位小数
        /// </summary>
        [XmlElement("voucher_amount")]
        public string VoucherAmount { get; set; }

        /// <summary>
        /// 券使用说明
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券失效时间
        /// </summary>
        [XmlElement("voucher_effective_end_time")]
        public string VoucherEffectiveEndTime { get; set; }

        /// <summary>
        /// 券生效时间
        /// </summary>
        [XmlElement("voucher_effective_start_time")]
        public string VoucherEffectiveStartTime { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券使用跳链
        /// </summary>
        [XmlElement("voucher_jump_url")]
        public string VoucherJumpUrl { get; set; }

        /// <summary>
        /// 优惠券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 已使用
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
