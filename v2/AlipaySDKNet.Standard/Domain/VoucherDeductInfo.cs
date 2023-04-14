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
        /// 自定义券类型
        /// </summary>
        [XmlElement("customer_define_voucher_info")]
        public CustomerDefineVoucherInfo CustomerDefineVoucherInfo { get; set; }

        /// <summary>
        /// 折扣券详情。
        /// </summary>
        [XmlElement("discount_voucher_info")]
        public DiscountVoucherInfo DiscountVoucherInfo { get; set; }

        /// <summary>
        /// 兑换券详情。
        /// </summary>
        [XmlElement("exchange_voucher_info")]
        public ExchangeVoucherInfo ExchangeVoucherInfo { get; set; }

        /// <summary>
        /// 满减券详情。
        /// </summary>
        [XmlElement("fix_voucher_info")]
        public FixVoucherInfo FixVoucherInfo { get; set; }

        /// <summary>
        /// 特价券详情。
        /// </summary>
        [XmlElement("special_voucher_info")]
        public SpecialVoucherInfo SpecialVoucherInfo { get; set; }

        /// <summary>
        /// 券类型。
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
