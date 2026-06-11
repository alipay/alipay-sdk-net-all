using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayTripQuerystatusResponse.
    /// </summary>
    public class AlipayCommerceTransportExpresswayTripQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 路网侧扣款行程单号： 1、需要与真实的扣款行程对应 2、路网侧全国车牌付场景下唯一
        /// </summary>
        [XmlElement("out_trip_id")]
        public string OutTripId { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 行程需扣费金额，单位人民币元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号，只有交易支付成功后才会返回
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 行程扣款状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 支付宝侧行程Id
        /// </summary>
        [XmlElement("trip_id")]
        public string TripId { get; set; }
    }
}
