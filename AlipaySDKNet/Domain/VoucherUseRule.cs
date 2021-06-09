using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseRule Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseRule : AopObject
    {
        /// <summary>
        /// 代金券详情
        /// </summary>
        [XmlElement("fix_voucher")]
        public FixVoucher FixVoucher { get; set; }

        /// <summary>
        /// 日期区间内可以使用优惠
        /// </summary>
        [XmlElement("voucher_valid_period")]
        public VoucherValidPeriod VoucherValidPeriod { get; set; }
    }
}
