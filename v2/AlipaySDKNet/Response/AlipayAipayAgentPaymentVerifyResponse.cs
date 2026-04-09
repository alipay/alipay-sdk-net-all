using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayAgentPaymentVerifyResponse.
    /// </summary>
    public class AlipayAipayAgentPaymentVerifyResponse : AopResponse
    {
        /// <summary>
        /// 支付凭证是否有效
        /// </summary>
        [XmlElement("active")]
        public bool Active { get; set; }

        /// <summary>
        /// 订单金额，CNY
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 外部幂等号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 卖家自定义的resourceId
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 支付宝交易号，交易的唯一标识
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
