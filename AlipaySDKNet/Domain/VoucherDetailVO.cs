using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDetailVO : AopObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 活动发起方LOGO
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 活动发起方名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 优惠封顶金额
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券不可用时间详细规
        /// </summary>
        [XmlArray("disable_detail_period")]
        [XmlArrayItem("time_period_rule")]
        public List<TimePeriodRule> DisableDetailPeriod { get; set; }

        /// <summary>
        /// 优惠折扣比例
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 券优惠类型; DISCOUNT: 折扣 FIX: 代金
        /// </summary>
        [XmlElement("discount_calc_type")]
        public string DiscountCalcType { get; set; }

        /// <summary>
        /// 门槛金额
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 单品券场景下, 单品券能够核销的货品ID列表
        /// </summary>
        [XmlArray("goods_id")]
        [XmlArrayItem("string")]
        public List<string> GoodsId { get; set; }

        /// <summary>
        /// 券的领取时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 券状态; ENABLED: 可用, DISABLED: 不可用, EXPIRED: 已过期
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券使用时间详细规则
        /// </summary>
        [XmlArray("usable_detail_period")]
        [XmlArrayItem("time_period_rule")]
        public List<TimePeriodRule> UsableDetailPeriod { get; set; }

        /// <summary>
        /// 券生效结束时间
        /// </summary>
        [XmlElement("usable_end_time")]
        public string UsableEndTime { get; set; }

        /// <summary>
        /// 券生效开始时间
        /// </summary>
        [XmlElement("usable_start_time")]
        public string UsableStartTime { get; set; }

        /// <summary>
        /// 券使用说明
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券类型;  GLOBAL_MONEY_OFF_VOUCHER: 全场代金券,  GLOBAL_DISCOUNT_VOUCHER: 全场折扣券, ITEM_MONEY_OFF_VOUCHER:单品代金券, ITEM_DISCOUNT_VOUCHER:单品折扣券
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
