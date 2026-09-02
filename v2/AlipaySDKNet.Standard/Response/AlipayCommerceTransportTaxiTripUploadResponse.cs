using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiTripUploadResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiTripUploadResponse : AopResponse
    {
        /// <summary>
        /// 写入tripId-可以无视返回结果
        /// </summary>
        [XmlElement("trip_id")]
        public string TripId { get; set; }
    }
}
