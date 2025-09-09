using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherQueryUseRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherQueryUseRuleInfo : AopObject
    {
        /// <summary>
        /// 券核销时间
        /// </summary>
        [XmlElement("app_item_voucher_use_time_info")]
        public AppItemVoucherQueryUseTimeInfo AppItemVoucherUseTimeInfo { get; set; }
    }
}
