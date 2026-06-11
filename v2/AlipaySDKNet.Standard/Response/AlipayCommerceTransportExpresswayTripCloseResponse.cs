using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayTripCloseResponse.
    /// </summary>
    public class AlipayCommerceTransportExpresswayTripCloseResponse : AopResponse
    {
        /// <summary>
        /// 路网侧扣款行程单号
        /// </summary>
        [XmlElement("out_trip_id")]
        public string OutTripId { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
