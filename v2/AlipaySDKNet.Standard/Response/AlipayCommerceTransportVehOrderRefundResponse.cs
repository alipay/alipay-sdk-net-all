using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehOrderRefundResponse.
    /// </summary>
    public class AlipayCommerceTransportVehOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 分润金额
        /// </summary>
        [XmlElement("refund_applets_service_amount")]
        public string RefundAppletsServiceAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
