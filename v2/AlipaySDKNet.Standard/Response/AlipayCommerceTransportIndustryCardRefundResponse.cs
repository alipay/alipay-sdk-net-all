using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIndustryCardRefundResponse.
    /// </summary>
    public class AlipayCommerceTransportIndustryCardRefundResponse : AopResponse
    {
        /// <summary>
        /// 退卡状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
