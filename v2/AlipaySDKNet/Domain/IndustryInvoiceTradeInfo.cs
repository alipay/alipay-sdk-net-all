using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInvoiceTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInvoiceTradeInfo : AopObject
    {
        /// <summary>
        /// 交易渠道
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 订单交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
