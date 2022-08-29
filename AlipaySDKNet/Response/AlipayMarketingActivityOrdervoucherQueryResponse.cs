using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherQueryResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动基础信息
        /// </summary>
        [XmlElement("activity_base_info")]
        public ActivityBaseInfo ActivityBaseInfo { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称。不对用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动操作状态
        /// </summary>
        [XmlElement("activity_operation_status")]
        public string ActivityOperationStatus { get; set; }

        /// <summary>
        /// 活动状态。已激活状态代表活动正常运行，已终止状态代表商家终止活动，不可再发放。
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 活动所属的商户信息
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public BelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 商家券业务标签，影响商家券对C端用户的展示形式。
        /// </summary>
        [XmlElement("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 用户引导相关配置
        /// </summary>
        [XmlElement("customer_guide")]
        public CustomerGuide CustomerGuide { get; set; }

        /// <summary>
        /// 券发放结束时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 券汇总信息
        /// </summary>
        [XmlElement("summary")]
        public VoucherSummary Summary { get; set; }

        /// <summary>
        /// 券可用范围
        /// </summary>
        [XmlElement("voucher_available_scope_info")]
        public VoucherAvailableScopeInfo VoucherAvailableScopeInfo { get; set; }

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
        /// 券展示信息
        /// </summary>
        [XmlElement("voucher_display_info")]
        public VoucherDisplayInfo VoucherDisplayInfo { get; set; }

        /// <summary>
        /// 券展示信息
        /// </summary>
        [XmlElement("voucher_display_pattern_info")]
        public VoucherDisplayPatternInfo VoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// 券库存信息
        /// </summary>
        [XmlElement("voucher_inventory_info")]
        public VoucherInventoryInfo VoucherInventoryInfo { get; set; }

        /// <summary>
        /// 券发放
        /// </summary>
        [XmlElement("voucher_send_mode_info")]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("voucher_send_rule")]
        public VoucherSendRuleDetail VoucherSendRule { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券使用规则
        /// </summary>
        [XmlElement("voucher_use_rule")]
        public VoucherUseRule VoucherUseRule { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule_info")]
        public VoucherUseRuleInfo VoucherUseRuleInfo { get; set; }
    }
}
