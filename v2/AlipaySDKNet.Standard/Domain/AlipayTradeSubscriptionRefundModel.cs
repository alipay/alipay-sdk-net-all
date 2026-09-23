using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSubscriptionRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSubscriptionRefundModel : AopObject
    {
        /// <summary>
        /// 商户退款请求号，用于退款请求幂等。同一笔退款重试时必须保持不变；同一交易发起多次部分退款时，每次须使用不同的请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 退款金额，单位为分。必须大于0，且累计退款金额不得超过原交易的可退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 订阅ID
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 支付宝交易号，必须为该订阅下可退款的原支付交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
