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
    }
}
