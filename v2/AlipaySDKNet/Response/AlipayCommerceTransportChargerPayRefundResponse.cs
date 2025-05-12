using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerPayRefundResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerPayRefundResponse : AopResponse
    {
        /// <summary>
        /// 行业退款业务流水号
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }
    }
}
