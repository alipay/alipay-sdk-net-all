using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportNpayOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportNpayOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 行业订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
