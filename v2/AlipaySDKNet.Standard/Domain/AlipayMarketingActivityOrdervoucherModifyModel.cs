using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrdervoucherModifyModel : AopObject
    {
        /// <summary>
        /// 活动基础信息
        /// </summary>
        [XmlElement("activity_base_info")]
        public ActivityBaseInfo ActivityBaseInfo { get; set; }

        /// <summary>
        /// 活动id1
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 引导用户配置。该值为空表示不修改。
        /// </summary>
        [XmlElement("customer_guide")]
        public CustomerGuideModify CustomerGuide { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券发放结束时间。该值为空表示不修改 格式为：yyyy-MM-dd HH:mm:ss
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
        /// 可用范围修改类型。
        /// </summary>
        [XmlElement("voucher_available_scope_modify_type")]
        public string VoucherAvailableScopeModifyType { get; set; }

        /// <summary>
        /// 券引导详情
        /// </summary>
        [XmlElement("voucher_customer_guide_info")]
        public VoucherCustomerGuideInfo VoucherCustomerGuideInfo { get; set; }

        /// <summary>
        /// 券展示信息。该值为空表示不修改。
        /// </summary>
        [XmlElement("voucher_display_info")]
        public VoucherDisplayInfoModify VoucherDisplayInfo { get; set; }

        /// <summary>
        /// 券展示信息
        /// </summary>
        [XmlElement("voucher_display_pattern_info")]
        public VoucherDisplayPatternInfo VoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// 券发放
        /// </summary>
        [XmlElement("voucher_send_mode_info")]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("voucher_send_rule")]
        public VoucherSendRuleDetailModify VoucherSendRule { get; set; }

        /// <summary>
        /// 券使用规则。该值为空表示不修改。
        /// </summary>
        [XmlElement("voucher_use_rule")]
        public VoucherUseRuleModify VoucherUseRule { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule_info")]
        public VoucherUseRuleInfo VoucherUseRuleInfo { get; set; }
    }
}
