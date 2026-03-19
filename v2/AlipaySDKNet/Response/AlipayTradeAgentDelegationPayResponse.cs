using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeAgentDelegationPayResponse.
    /// </summary>
    public class AlipayTradeAgentDelegationPayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
