using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceResaleOrderRefundResponse.
    /// </summary>
    public class AlipayCommerceResaleOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 退款编码
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }
    }
}
