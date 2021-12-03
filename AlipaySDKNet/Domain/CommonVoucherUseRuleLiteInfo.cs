using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonVoucherUseRuleLiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommonVoucherUseRuleLiteInfo : AopObject
    {
        /// <summary>
        /// 折扣券详情 限制: voucher_type为DISCOUNT_VOUCHER时必传
        /// </summary>
        [XmlElement("discount_voucher")]
        public ActivityDiscountVoucher DiscountVoucher { get; set; }

        /// <summary>
        /// 兑换券详情 限制: voucher_type为EXCHANGE_VOUCHER时必传
        /// </summary>
        [XmlElement("exchange_voucher")]
        public ActivityExchangeVoucher ExchangeVoucher { get; set; }

        /// <summary>
        /// 满减券详情 限制: voucher_type为FIX_VOUCHER时必传
        /// </summary>
        [XmlElement("fix_voucher")]
        public ActivityFixVoucher FixVoucher { get; set; }

        /// <summary>
        /// 特价券详情 限制: voucher_type为SPECIAL_VOUCHER时必传
        /// </summary>
        [XmlElement("special_voucher")]
        public ActivitySpecialVoucher SpecialVoucher { get; set; }
    }
}
