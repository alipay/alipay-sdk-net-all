using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberWalletBalanceDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class MemberWalletBalanceDetailVO : AopObject
    {
        /// <summary>
        /// 权益金变更金额（单位：元）
        /// </summary>
        [XmlElement("benefit_amount")]
        public string BenefitAmount { get; set; }

        /// <summary>
        /// 本金变更金额（单位：元）
        /// </summary>
        [XmlElement("principal_amount")]
        public string PrincipalAmount { get; set; }

        /// <summary>
        /// 订单金额（单位：元）
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 余额变更类型 <br>recharge 充值 <br>refund 退款
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
