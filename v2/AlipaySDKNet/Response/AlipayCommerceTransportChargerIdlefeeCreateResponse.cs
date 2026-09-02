using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerIdlefeeCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerIdlefeeCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝占位费订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
