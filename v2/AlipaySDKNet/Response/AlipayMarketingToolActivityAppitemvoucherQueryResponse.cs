using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolActivityAppitemvoucherQueryResponse.
    /// </summary>
    public class AlipayMarketingToolActivityAppitemvoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动基础信息
        /// </summary>
        [XmlElement("app_item_activity_base_info")]
        public AppItemActivityQueryBaseInfo AppItemActivityBaseInfo { get; set; }

        /// <summary>
        /// 券出资方式
        /// </summary>
        [XmlElement("app_item_voucher_budget_supply_info")]
        public AppItemVoucherQueryBudgetSupplyInfo AppItemVoucherBudgetSupplyInfo { get; set; }

        /// <summary>
        /// 引导信息
        /// </summary>
        [XmlElement("app_item_voucher_customer_guide_info")]
        public AppItemVoucherQueryCustomerGuideInfo AppItemVoucherCustomerGuideInfo { get; set; }

        /// <summary>
        /// 券优惠信息
        /// </summary>
        [XmlElement("app_item_voucher_deduct_info")]
        public AppItemVoucherQueryDeductInfo AppItemVoucherDeductInfo { get; set; }

        /// <summary>
        /// 券展示信息
        /// </summary>
        [XmlElement("app_item_voucher_display_pattern_info")]
        public AppItemVoucherQueryDisplayPatternInfo AppItemVoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// 券发放信息
        /// </summary>
        [XmlElement("app_item_voucher_send_mode_info")]
        public AppItemVoucherQuerySendModeInfo AppItemVoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("app_item_voucher_use_rule_info")]
        public AppItemVoucherQueryUseRuleInfo AppItemVoucherUseRuleInfo { get; set; }
    }
}
