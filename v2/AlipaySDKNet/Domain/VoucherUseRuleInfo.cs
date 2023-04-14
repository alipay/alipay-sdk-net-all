using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseRuleInfo : AopObject
    {
        /// <summary>
        /// 核销次数限制。
        /// </summary>
        [XmlElement("quantity_limit_per_user")]
        public long QuantityLimitPerUser { get; set; }

        /// <summary>
        /// 核销周期。
        /// </summary>
        [XmlElement("quantity_limit_per_user_period_type")]
        public string QuantityLimitPerUserPeriodType { get; set; }

        /// <summary>
        /// 券最大核销次数。
        /// </summary>
        [XmlElement("voucher_max_use_times")]
        public long VoucherMaxUseTimes { get; set; }

        /// <summary>
        /// 自定义扩展信息
        /// </summary>
        [XmlElement("voucher_use_ext_info")]
        public string VoucherUseExtInfo { get; set; }

        /// <summary>
        /// 券核销时间。
        /// </summary>
        [XmlElement("voucher_use_time_info")]
        public VoucherUseTimeInfo VoucherUseTimeInfo { get; set; }
    }
}
