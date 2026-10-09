using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonVoucherUseRule Data Structure.
    /// </summary>
    [Serializable]
    public class CommonVoucherUseRule : AopObject
    {
        /// <summary>
        /// 折扣券详情。
        /// </summary>
        [XmlElement("discount_voucher")]
        public ActivityDiscountVoucher DiscountVoucher { get; set; }

        /// <summary>
        /// 兑换券详情。
        /// </summary>
        [XmlElement("exchange_voucher")]
        public ActivityExchangeVoucher ExchangeVoucher { get; set; }

        /// <summary>
        /// 满减券详情。
        /// </summary>
        [XmlElement("fix_voucher")]
        public ActivityFixVoucher FixVoucher { get; set; }

        /// <summary>
        /// 特价券详情。
        /// </summary>
        [XmlElement("special_voucher")]
        public ActivitySpecialVoucher SpecialVoucher { get; set; }
    }
}
