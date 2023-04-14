using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherRechargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherRechargeInfo : AopObject
    {
        /// <summary>
        /// 余额预充值详情 限制: 1、recharge_type为ALIPAY_BALANCE时必传
        /// </summary>
        [XmlElement("alipay_balance_recharge_info")]
        public PaymentVoucherAlipayBalanceRechargeInfo AlipayBalanceRechargeInfo { get; set; }

        /// <summary>
        /// 预充值方式。  枚举值 ALIPAY_BALANCE 支付宝余额预充值
        /// </summary>
        [XmlElement("recharge_type")]
        public string RechargeType { get; set; }
    }
}
