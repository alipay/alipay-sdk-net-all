using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSubscriptionPayResponse.
    /// </summary>
    public class AlipayTradeSubscriptionPayResponse : AopResponse
    {
        /// <summary>
        /// 支付请求受理时生成的支付请求单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户侧外部单号，幂等键。一致则重新唤起原单支付，不一致则重新创单
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 16 扣款状态。 PENDING_PAY 待支付 PAID 已支付
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订阅id，订阅唯一标识
        /// </summary>
        [XmlElement("subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 支付宝交易号（仅支付受理成功时返回）
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
