using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderRefundResponse.
    /// </summary>
    public class AlipayOpenMiniOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 退款id
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 本次商户实际退回金额,单位"元"
        /// </summary>
        [XmlElement("send_back_fee")]
        public string SendBackFee { get; set; }
    }
}
