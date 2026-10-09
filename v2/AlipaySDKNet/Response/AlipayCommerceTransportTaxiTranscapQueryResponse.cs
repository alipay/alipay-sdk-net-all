using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiTranscapQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiTranscapQueryResponse : AopResponse
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 位置点列表
        /// </summary>
        [XmlArray("positions")]
        [XmlArrayItem("position_point")]
        public List<PositionPoint> Positions { get; set; }

        /// <summary>
        /// 车辆/机具ID
        /// </summary>
        [XmlElement("vehicle_id")]
        public string VehicleId { get; set; }
    }
}
