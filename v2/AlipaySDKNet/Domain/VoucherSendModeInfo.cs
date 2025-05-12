using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherSendModeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherSendModeInfo : AopObject
    {
        /// <summary>
        /// 推广渠道列表
        /// </summary>
        [XmlArray("delivery_channel_list")]
        [XmlArrayItem("string")]
        public List<string> DeliveryChannelList { get; set; }

        /// <summary>
        /// 券包信息。
        /// </summary>
        [XmlElement("voucher_package_mode_info")]
        public VoucherPackageModeInfo VoucherPackageModeInfo { get; set; }

        /// <summary>
        /// 券售卖信息。
        /// </summary>
        [XmlElement("voucher_sale_mode_info")]
        public VoucherSaleModeInfo VoucherSaleModeInfo { get; set; }

        /// <summary>
        /// 券发放模式。
        /// </summary>
        [XmlElement("voucher_send_mode")]
        public string VoucherSendMode { get; set; }

        /// <summary>
        /// 券发放规则。
        /// </summary>
        [XmlElement("voucher_send_rule_info")]
        public VoucherSendRuleInfo VoucherSendRuleInfo { get; set; }
    }
}
