using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboRecord Data Structure.
    /// </summary>
    [Serializable]
    public class RoboRecord : AopObject
    {
        /// <summary>
        /// 行程结束时间 2025-11-05 18:30
        /// </summary>
        [XmlElement("arrive_dest_time")]
        public string ArriveDestTime { get; set; }

        /// <summary>
        /// 行程开始时间格式 2025-11-05 18:00
        /// </summary>
        [XmlElement("begin_charge_time")]
        public string BeginChargeTime { get; set; }

        /// <summary>
        /// 车辆到达时间
        /// </summary>
        [XmlElement("driver_reach_time")]
        public string DriverReachTime { get; set; }

        /// <summary>
        /// 车辆出发时间
        /// </summary>
        [XmlElement("driver_server_time")]
        public string DriverServerTime { get; set; }
    }
}
