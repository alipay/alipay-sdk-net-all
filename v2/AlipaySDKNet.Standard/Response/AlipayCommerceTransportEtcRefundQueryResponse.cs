using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcRefundQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户侧唯一的行程号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款状态： "I","未知，原请求单号需要重试";  "RI", "退款中，原请求单号需要重试";  "R", "已退款";  "PR", "部分退款";
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
