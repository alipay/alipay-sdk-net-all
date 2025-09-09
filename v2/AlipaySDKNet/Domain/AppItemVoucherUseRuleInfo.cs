using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherUseRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherUseRuleInfo : AopObject
    {
        /// <summary>
        /// 券核销时间
        /// </summary>
        [XmlElement("app_item_voucher_use_time_info")]
        public AppItemVoucherUseTimeInfo AppItemVoucherUseTimeInfo { get; set; }
    }
}
