using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportCarsaleBtoborderSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportCarsaleBtoborderSyncResponse : AopResponse
    {
        /// <summary>
        /// 车生活订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
