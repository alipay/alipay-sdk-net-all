using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherDeductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDeductInfo : AopObject
    {
        /// <summary>
        /// 折扣券详情 限制: 券类型voucher_type为折扣券DISCOUNT_VOUCHER时必传
        /// </summary>
        [XmlElement("discount_voucher_info")]
        public DiscountVoucherInfo DiscountVoucherInfo { get; set; }

        /// <summary>
        /// 兑换券详情 限制: 券类型为兑换券时必传
        /// </summary>
        [XmlElement("exchange_voucher_info")]
        public ExchangeVoucherInfo ExchangeVoucherInfo { get; set; }

        /// <summary>
        /// 满减券详情 限制: 券类型为满减券时必传
        /// </summary>
        [XmlElement("fix_voucher_info")]
        public FixVoucherInfo FixVoucherInfo { get; set; }

        /// <summary>
        /// 特价券详情 限制: 券类型voucher_type为特价券SPECIAL_VOUCHER时必传
        /// </summary>
        [XmlElement("special_voucher_info")]
        public SpecialVoucherInfo SpecialVoucherInfo { get; set; }

        /// <summary>
        /// 券类型。 枚举值： 商家券支持三类券类型： FIX_VOUCHER：满减券； DISCOUNT_VOUCHER：折扣券； SPECIAL_VOUCHER：特价券； 兑换券仅支持一类券类型： EXCHANGE_VOUCHER: 兑换券；
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
