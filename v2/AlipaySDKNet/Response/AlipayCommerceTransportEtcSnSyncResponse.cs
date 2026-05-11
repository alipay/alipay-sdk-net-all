using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcSnSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcSnSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝侧业务订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
