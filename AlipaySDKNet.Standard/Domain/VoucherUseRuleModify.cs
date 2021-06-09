using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseRuleModify Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseRuleModify : AopObject
    {
        /// <summary>
        /// 日期区间内可以使用优惠
        /// </summary>
        [XmlElement("voucher_valid_period")]
        public VoucherValidPeriodModify VoucherValidPeriod { get; set; }
    }
}
