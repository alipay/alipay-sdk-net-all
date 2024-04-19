using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherRechargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherRechargeInfo : AopObject
    {
        /// <summary>
        /// 预充值方式。
        /// </summary>
        [XmlElement("recharge_type")]
        public string RechargeType { get; set; }

        /// <summary>
        /// "余额预充值详情 限制: recharge_type为ALIPAY_BALANCE时必传"
        /// </summary>
        [XmlElement("voucher_balance_recharge_info")]
        public VoucherBalanceRechargeInfo VoucherBalanceRechargeInfo { get; set; }
    }
}
