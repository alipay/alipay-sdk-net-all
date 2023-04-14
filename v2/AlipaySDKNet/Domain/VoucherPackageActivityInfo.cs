using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherPackageActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherPackageActivityInfo : AopObject
    {
        /// <summary>
        /// 活动基本信息
        /// </summary>
        [XmlElement("activity_base_info")]
        public ActivityBaseInfo ActivityBaseInfo { get; set; }

        /// <summary>
        /// 券可用范围
        /// </summary>
        [XmlElement("voucher_available_scope_info")]
        public VoucherAvailableScopeInfo VoucherAvailableScopeInfo { get; set; }

        /// <summary>
        /// 优惠券抵扣信息
        /// </summary>
        [XmlElement("voucher_deduct_info")]
        public VoucherDeductInfo VoucherDeductInfo { get; set; }

        /// <summary>
        /// 券的展示详情
        /// </summary>
        [XmlElement("voucher_display_pattern_info")]
        public VoucherDisplayPatternInfo VoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// 券的发放方式
        /// </summary>
        [XmlElement("voucher_send_mode_info")]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule_info")]
        public VoucherUseRuleInfo VoucherUseRuleInfo { get; set; }
    }
}
