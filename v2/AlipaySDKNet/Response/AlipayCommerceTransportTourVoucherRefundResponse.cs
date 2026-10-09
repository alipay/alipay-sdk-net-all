using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTourVoucherRefundResponse.
    /// </summary>
    public class AlipayCommerceTransportTourVoucherRefundResponse : AopResponse
    {
        /// <summary>
        /// 外部退款请求流水号
        /// </summary>
        [XmlElement("out_refund_id")]
        public string OutRefundId { get; set; }

        /// <summary>
        /// 退款金额：本次商户实际退回金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
