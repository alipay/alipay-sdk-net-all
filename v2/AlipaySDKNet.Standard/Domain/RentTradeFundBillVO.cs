using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentTradeFundBillVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentTradeFundBillVO : AopObject
    {
        /// <summary>
        /// 该支付工具类型所使用的金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易使用的资金渠道: ALIPAYACCOUNT(支付宝账户)、COUPON(支付宝红包)、POINT(集分宝)、DISCOUNT(折扣券)、PCARD(预付卡)、MCARD(商家储值卡)、MDISCOUNT(商户优惠券)、MCOUPON(商户红包)、BANKCARD(银行卡)、MONEYFUND(余额宝)、VOUCHER（券）、DCEP_ASSET（数字人民币）
        /// </summary>
        [XmlElement("fund_channel")]
        public string FundChannel { get; set; }

        /// <summary>
        /// 渠道实际付款金额。单位：元
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }
    }
}
