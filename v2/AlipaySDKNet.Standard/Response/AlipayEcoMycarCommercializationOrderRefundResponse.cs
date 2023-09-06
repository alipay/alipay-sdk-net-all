using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarCommercializationOrderRefundResponse.
    /// </summary>
    public class AlipayEcoMycarCommercializationOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 退款单状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
