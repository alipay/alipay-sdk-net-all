using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherModifySendModeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherModifySendModeInfo : AopObject
    {
        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("app_item_voucher_send_rule_info")]
        public AppItemVoucherModifySendRuleInfo AppItemVoucherSendRuleInfo { get; set; }
    }
}
