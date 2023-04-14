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
        /// 兑换券详情。
        /// </summary>
        [XmlElement("exchange_voucher")]
        public ExchangeVoucherModify ExchangeVoucher { get; set; }

        /// <summary>
        /// 券可用范围修改信息。
        /// </summary>
        [XmlElement("voucher_available_scope")]
        public VoucherAvailableScopeModify VoucherAvailableScope { get; set; }

        /// <summary>
        /// 日期区间内可以使用优惠。
        /// </summary>
        [XmlElement("voucher_valid_period")]
        public VoucherValidPeriodModify VoucherValidPeriod { get; set; }
    }
}
