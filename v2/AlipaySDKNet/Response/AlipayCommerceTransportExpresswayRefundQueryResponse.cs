using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayRefundQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportExpresswayRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 外部退款流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 路网侧扣款行程单号
        /// </summary>
        [XmlElement("out_trip_id")]
        public string OutTripId { get; set; }

        /// <summary>
        /// 本次需要退款的金额： 1、单位为元； 2、该金额不能大于行程扣款的金额； 3、支持两位小数；
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款完成时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }
    }
}
