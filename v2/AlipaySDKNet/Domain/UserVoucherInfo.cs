using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserVoucherInfo : AopObject
    {
        /// <summary>
        /// 活动基础信息。
        /// </summary>
        [XmlElement("activity_base_info")]
        public ActivityBaseInfo ActivityBaseInfo { get; set; }

        /// <summary>
        /// 活动 id。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 券可用开始时间。
        /// </summary>
        [XmlElement("available_begin_time")]
        public string AvailableBeginTime { get; set; }

        /// <summary>
        /// 券可用结束时间。
        /// </summary>
        [XmlElement("available_end_time")]
        public string AvailableEndTime { get; set; }

        /// <summary>
        /// 券归属商户 pid。
        /// </summary>
        [XmlElement("belong_merchant_id")]
        public string BelongMerchantId { get; set; }

        /// <summary>
        /// 用户领券时间。
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 用户券实例信息。
        /// </summary>
        [XmlElement("user_voucher_base_info")]
        public UserVoucherBaseInfo UserVoucherBaseInfo { get; set; }

        /// <summary>
        /// 券可用范围。
        /// </summary>
        [XmlElement("voucher_available_scope_info")]
        public VoucherAvailableScopeInfo VoucherAvailableScopeInfo { get; set; }

        /// <summary>
        /// 券优惠信息。
        /// </summary>
        [XmlElement("voucher_deduct_info")]
        public VoucherDeductInfo VoucherDeductInfo { get; set; }

        /// <summary>
        /// 券展示信息。
        /// </summary>
        [XmlElement("voucher_display_lite_info")]
        public CommonVoucherDisplayLiteInfo VoucherDisplayLiteInfo { get; set; }

        /// <summary>
        /// 券展示信息。
        /// </summary>
        [XmlElement("voucher_display_pattern_info")]
        public VoucherDisplayPatternInfo VoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// 用户券 id。支付宝为用户优惠券唯一分配的 id。
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券名称。展示在支付宝卡包中的券名称。
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券发放信息。
        /// </summary>
        [XmlElement("voucher_send_mode_info")]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券状态。
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 券类型。
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule_info")]
        public VoucherUseRuleInfo VoucherUseRuleInfo { get; set; }

        /// <summary>
        /// 券核销规则。
        /// </summary>
        [XmlElement("voucher_use_rule_lite_info")]
        public CommonVoucherUseRuleLiteInfo VoucherUseRuleLiteInfo { get; set; }
    }
}
