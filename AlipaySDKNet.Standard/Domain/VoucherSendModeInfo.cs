using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSendModeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSendModeInfo : AopObject
    {
        /// <summary>
        /// 券包信息
        /// </summary>
        [XmlElement("voucher_package_mode_info")]
        public VoucherPackageModeInfo VoucherPackageModeInfo { get; set; }

        /// <summary>
        /// 券售卖信息
        /// </summary>
        [XmlElement("voucher_sale_mode_info")]
        public VoucherSaleModeInfo VoucherSaleModeInfo { get; set; }

        /// <summary>
        /// 券发放模式 枚举值: SALE_MODE:售卖模式 DIRECT_SEND_MODE:直领模式 VOUCHER_PACKAGE:券包
        /// </summary>
        [XmlElement("voucher_send_mode")]
        public string VoucherSendMode { get; set; }

        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("voucher_send_rule_info")]
        public VoucherSendRuleInfo VoucherSendRuleInfo { get; set; }
    }
}
