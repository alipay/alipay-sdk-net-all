using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolActivityAppitemvoucherCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolActivityAppitemvoucherCreateModel : AopObject
    {
        /// <summary>
        /// 活动基本信息
        /// </summary>
        [XmlElement("app_item_activity_base_info")]
        public AppItemActivityBaseInfo AppItemActivityBaseInfo { get; set; }

        /// <summary>
        /// 券可用范围
        /// </summary>
        [XmlElement("app_item_voucher_available_scope_info")]
        public AppItemVoucherAvailableScopeInfo AppItemVoucherAvailableScopeInfo { get; set; }

        /// <summary>
        /// 券出资方式
        /// </summary>
        [XmlElement("app_item_voucher_budget_supply_info")]
        public AppItemVoucherBudgetSupplyInfo AppItemVoucherBudgetSupplyInfo { get; set; }

        /// <summary>
        /// 引导信息
        /// </summary>
        [XmlElement("app_item_voucher_customer_guide_info")]
        public AppItemVoucherCustomerGuideInfo AppItemVoucherCustomerGuideInfo { get; set; }

        /// <summary>
        /// 券优惠信息
        /// </summary>
        [XmlElement("app_item_voucher_deduct_info")]
        public AppItemVoucherDeductInfo AppItemVoucherDeductInfo { get; set; }

        /// <summary>
        /// 券展示方式
        /// </summary>
        [XmlElement("app_item_voucher_display_pattern_info")]
        public AppItemVoucherDisplayPatternInfo AppItemVoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// 券发放方式
        /// </summary>
        [XmlElement("app_item_voucher_send_mode_info")]
        public AppItemVoucherSendModeInfo AppItemVoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("app_item_voucher_use_rule_info")]
        public AppItemVoucherUseRuleInfo AppItemVoucherUseRuleInfo { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
