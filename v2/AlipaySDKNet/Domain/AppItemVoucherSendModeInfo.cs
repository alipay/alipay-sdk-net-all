using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherSendModeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherSendModeInfo : AopObject
    {
        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("app_item_voucher_send_rule_info")]
        public AppItemVoucherSendRuleInfo AppItemVoucherSendRuleInfo { get; set; }

        /// <summary>
        /// 券发放模式 直领模式: DIRECT_SEND_MODE
        /// </summary>
        [XmlElement("voucher_send_mode")]
        public string VoucherSendMode { get; set; }
    }
}
