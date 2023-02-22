using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeRestrictInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TimeRestrictInfo : AopObject
    {
        /// <summary>
        /// 不可用时间段
        /// </summary>
        [XmlArray("disable_period_info")]
        [XmlArrayItem("voucher_use_time_rule_info")]
        public List<VoucherUseTimeRuleInfo> DisablePeriodInfo { get; set; }

        /// <summary>
        /// 可用时间段
        /// </summary>
        [XmlArray("usable_period_info")]
        [XmlArrayItem("voucher_use_time_rule_info")]
        public List<VoucherUseTimeRuleInfo> UsablePeriodInfo { get; set; }
    }
}
