using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelStatistic Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelStatistic : AopObject
    {
        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 当前渠道，退款成功的总金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 实际到账金额
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易笔数
        /// </summary>
        [XmlElement("trade_count")]
        public long TradeCount { get; set; }
    }
}
