using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityLiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityLiteInfo : AopObject
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
        /// 活动名称。 不对支付宝用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动状态。
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 归属商户 PID。
        /// </summary>
        [XmlElement("belong_merchant_id")]
        public string BelongMerchantId { get; set; }

        /// <summary>
        /// 活动创建时间。
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 券发放结束时间。格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

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
        /// 券展示规则。
        /// </summary>
        [XmlElement("voucher_display_lite_info")]
        public CommonVoucherDisplayLiteInfo VoucherDisplayLiteInfo { get; set; }

        /// <summary>
        /// 券展示信息。
        /// </summary>
        [XmlElement("voucher_display_pattern_info")]
        public VoucherDisplayPatternInfo VoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// 券发放。
        /// </summary>
        [XmlElement("voucher_send_mode_info")]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券类型。
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券核销。
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
