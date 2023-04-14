using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityVoucherCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityVoucherCreateModel : AopObject
    {
        /// <summary>
        /// 活动基础信息
        /// </summary>
        [XmlElement("activity_base_info")]
        public ActivityBaseInfo ActivityBaseInfo { get; set; }

        /// <summary>
        /// 活动名称。 不对用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 归属商户信息，默认归属商户为当前请求商户
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public PaymentVoucherBelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券发放结束时间。 格式为：yyyy-MM-dd HH:mm:ss 限制： 券发放结束时间 publish_end_time 与 券发放开始时间 publish_start_time 间隔必须小于等于180天
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 券可用范围
        /// </summary>
        [XmlElement("voucher_available_scope_info")]
        public VoucherAvailableScopeInfo VoucherAvailableScopeInfo { get; set; }

        /// <summary>
        /// 营销资金预算
        /// </summary>
        [XmlElement("voucher_budget_info")]
        public PaymentVoucherBudgetInfo VoucherBudgetInfo { get; set; }

        /// <summary>
        /// 资金信息
        /// </summary>
        [XmlElement("voucher_budget_supply_info")]
        public VoucherBudgetSupplyInfo VoucherBudgetSupplyInfo { get; set; }

        /// <summary>
        /// 券引导信息
        /// </summary>
        [XmlElement("voucher_customer_guide_info")]
        public VoucherCustomerGuideInfo VoucherCustomerGuideInfo { get; set; }

        /// <summary>
        /// 券优惠抵扣信息
        /// </summary>
        [XmlElement("voucher_deduct_info")]
        public VoucherDeductInfo VoucherDeductInfo { get; set; }

        /// <summary>
        /// 券详情页
        /// </summary>
        [XmlElement("voucher_display_info")]
        public PaymentVoucherDisplayInfo VoucherDisplayInfo { get; set; }

        /// <summary>
        /// 券展示信息
        /// </summary>
        [XmlElement("voucher_display_pattern_info")]
        public VoucherDisplayPatternInfo VoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// 券发放信息
        /// </summary>
        [XmlElement("voucher_send_mode_info")]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("voucher_send_rule")]
        public PaymentVoucherSendRule VoucherSendRule { get; set; }

        /// <summary>
        /// 优惠类型  枚举值： FIX_VOUCHER：固定面额满减券
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule")]
        public PaymentVoucherUseRule VoucherUseRule { get; set; }

        /// <summary>
        /// 券核销限制
        /// </summary>
        [XmlElement("voucher_use_rule_info")]
        public VoucherUseRuleInfo VoucherUseRuleInfo { get; set; }
    }
}
