using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayCardtripSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportExpresswayCardtripSyncResponse : AopResponse
    {
        /// <summary>
        /// 路网侧唯一高速行程单号
        /// </summary>
        [XmlElement("out_trip_id")]
        public string OutTripId { get; set; }

        /// <summary>
        /// 支付宝侧高速行程单号
        /// </summary>
        [XmlElement("trip_id")]
        public string TripId { get; set; }
    }
}
