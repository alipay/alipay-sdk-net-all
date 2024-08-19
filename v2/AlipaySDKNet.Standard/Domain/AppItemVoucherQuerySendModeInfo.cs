using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherQuerySendModeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherQuerySendModeInfo : AopObject
    {
        /// <summary>
        /// 券发放信息
        /// </summary>
        [XmlElement("app_item_voucher_send_mode_info")]
        public AppItemVoucherQuerySendRuleInfo AppItemVoucherSendModeInfo { get; set; }

        /// <summary>
        /// 发放模式
        /// </summary>
        [XmlElement("voucher_send_mode")]
        public string VoucherSendMode { get; set; }
    }
}
