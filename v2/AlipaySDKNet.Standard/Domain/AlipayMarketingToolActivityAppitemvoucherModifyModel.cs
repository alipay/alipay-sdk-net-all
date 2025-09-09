using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolActivityAppitemvoucherModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolActivityAppitemvoucherModifyModel : AopObject
    {
        /// <summary>
        /// 活动基础信息
        /// </summary>
        [XmlElement("app_item_activity_base_info")]
        public AppItemActivityModifyBaseInfo AppItemActivityBaseInfo { get; set; }

        /// <summary>
        /// 券可用范围
        /// </summary>
        [XmlElement("app_item_voucher_available_scope_info")]
        public AppItemVoucherModifyAvailableScopeInfo AppItemVoucherAvailableScopeInfo { get; set; }

        /// <summary>
        /// 券展示方式
        /// </summary>
        [XmlElement("app_item_voucher_display_pattern_info")]
        public AppItemVoucherModifyDisplayPatternInfo AppItemVoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// 券发放信息
        /// </summary>
        [XmlElement("app_item_voucher_send_mode_info")]
        public AppItemVoucherModifySendModeInfo AppItemVoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("app_item_voucher_use_rule_info")]
        public AppItemVoucherModifyUseRuleInfo AppItemVoucherUseRuleInfo { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
