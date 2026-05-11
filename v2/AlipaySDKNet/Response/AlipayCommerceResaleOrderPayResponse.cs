using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceResaleOrderPayResponse.
    /// </summary>
    public class AlipayCommerceResaleOrderPayResponse : AopResponse
    {
        /// <summary>
        /// 交易支付流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
