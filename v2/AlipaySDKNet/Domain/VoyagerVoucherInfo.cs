using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerVoucherInfo : AopObject
    {
        /// <summary>
        /// 行动按钮跳转地址
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 券详情地址（T&C 条款等在详情页展示）
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 优惠单位：金额类为币种（ISO 4217），非金额权益为 折/次 等
        /// </summary>
        [XmlElement("discount_unit")]
        public string DiscountUnit { get; set; }

        /// <summary>
        /// 优惠值（纯数值字符串）：金额券 500（分）、折扣券 8（8 折）、次数券 3
        /// </summary>
        [XmlElement("discount_value")]
        public string DiscountValue { get; set; }

        /// <summary>
        /// 券背景图 URL
        /// </summary>
        [XmlElement("gift_icon")]
        public string GiftIcon { get; set; }

        /// <summary>
        /// 最大优惠金额单位（ISO 4217 币种）
        /// </summary>
        [XmlElement("max_discount_unit")]
        public string MaxDiscountUnit { get; set; }

        /// <summary>
        /// 最大优惠金额（折扣券封顶场景，可选）
        /// </summary>
        [XmlElement("max_discount_value")]
        public string MaxDiscountValue { get; set; }

        /// <summary>
        /// 门槛单位（一般为 ISO 4217 币种），展示如"满20可用"
        /// </summary>
        [XmlElement("threshold_unit")]
        public string ThresholdUnit { get; set; }

        /// <summary>
        /// 门槛值（如满 100 可用传 10000）
        /// </summary>
        [XmlElement("threshold_value")]
        public string ThresholdValue { get; set; }

        /// <summary>
        /// 券使用条件（对客展示）
        /// </summary>
        [XmlElement("usage_condition")]
        public string UsageCondition { get; set; }

        /// <summary>
        /// 券有效期结束时间，根据类型而定，可能为具体的时间，也可能为妙
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 券有效期开始时间，根据类型而定，可能为具体的时间，也可能为妙
        /// </summary>
        [XmlElement("valid_start_time")]
        public string ValidStartTime { get; set; }

        /// <summary>
        /// 有效类型：ABSOLUTE 绝对时间 / RELATIVE 相对时间
        /// </summary>
        [XmlElement("valid_type")]
        public string ValidType { get; set; }

        /// <summary>
        /// 券图标 URL
        /// </summary>
        [XmlElement("voucher_icon")]
        public string VoucherIcon { get; set; }

        /// <summary>
        /// 券的对外名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券状态（用户视角）：NOT_CLAIMED（未领）/ CLAIMED（已领，存在可用券）/ USED（已使用，领取的券已全部核销）
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
