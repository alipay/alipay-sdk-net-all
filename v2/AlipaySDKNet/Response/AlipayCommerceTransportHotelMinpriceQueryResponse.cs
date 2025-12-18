using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportHotelMinpriceQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportHotelMinpriceQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝聚合酒店id
        /// </summary>
        [XmlElement("hotel_id")]
        public string HotelId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("min_rates")]
        [XmlArrayItem("min_rate")]
        public List<MinRate> MinRates { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("room_infos")]
        [XmlArrayItem("room_info")]
        public List<RoomInfo> RoomInfos { get; set; }
    }
}
