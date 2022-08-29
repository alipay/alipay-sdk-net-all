using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityUserQueryvoucherResponse.
    /// </summary>
    public class AlipayMarketingActivityUserQueryvoucherResponse : AopResponse
    {
        /// <summary>
        /// 活动基础信息
        /// </summary>
        [XmlElement("activity_base_info")]
        public ActivityBaseInfo ActivityBaseInfo { get; set; }

        /// <summary>
        /// 活动 id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 若商家券操作过关联商户订单信息，则该字段返回商家券已关联的商户订单号。
        /// </summary>
        [XmlElement("associate_trade_no")]
        public string AssociateTradeNo { get; set; }

        /// <summary>
        /// 券可用开始时间
        /// </summary>
        [XmlElement("available_begin_time")]
        public string AvailableBeginTime { get; set; }

        /// <summary>
        /// 券可用结束时间
        /// </summary>
        [XmlElement("available_end_time")]
        public string AvailableEndTime { get; set; }

        /// <summary>
        /// 券归属 pid
        /// </summary>
        [XmlElement("belong_merchant_id")]
        public string BelongMerchantId { get; set; }

        /// <summary>
        /// 领券时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 券实例基础信息
        /// </summary>
        [XmlElement("user_voucher_base_info")]
        public UserVoucherBaseInfo UserVoucherBaseInfo { get; set; }

        /// <summary>
        /// 券优惠信息
        /// </summary>
        [XmlElement("voucher_deduct_info")]
        public VoucherDeductInfo VoucherDeductInfo { get; set; }

        /// <summary>
        /// 券展示信息
        /// </summary>
        [XmlElement("voucher_display_info")]
        public CommonVoucherDisplayInfo VoucherDisplayInfo { get; set; }

        /// <summary>
        /// 券展示信息
        /// </summary>
        [XmlElement("voucher_display_pattern_info")]
        public VoucherDisplayPatternInfo VoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券发放
        /// </summary>
        [XmlElement("voucher_send_mode_info")]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("voucher_send_rule")]
        public CommonVoucherSendRule VoucherSendRule { get; set; }

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
        [XmlElement("voucher_use_rule")]
        public CommonVoucherUseRule VoucherUseRule { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule_info")]
        public VoucherUseRuleInfo VoucherUseRuleInfo { get; set; }
    }
}
