using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportMallOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportMallOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 订单同步相关状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
