using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherModifyUseRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherModifyUseRuleInfo : AopObject
    {
        /// <summary>
        /// 核销时间
        /// </summary>
        [XmlElement("app_item_voucher_use_time_info")]
        public AppItemVoucherModifyUseTimeInfo AppItemVoucherUseTimeInfo { get; set; }
    }
}
