using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkSchedulePlan Data Structure.
    /// </summary>
    [Serializable]
    public class WorkSchedulePlan : AopObject
    {
        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 排班计划中，车辆对应线路
        /// </summary>
        [XmlElement("line_key")]
        public string LineKey { get; set; }

        /// <summary>
        /// 车次链列表
        /// </summary>
        [XmlArray("trip_chain")]
        [XmlArrayItem("transport_trip")]
        public List<TransportTrip> TripChain { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [XmlElement("vehicle_id")]
        public string VehicleId { get; set; }
    }
}
