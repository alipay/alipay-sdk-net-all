using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTrafficshareTradeRefundResponse.
    /// </summary>
    public class AlipayCommerceTransportTrafficshareTradeRefundResponse : AopResponse
    {
        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("schedule_id")]
        public string ScheduleId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
