using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AirlineExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AirlineExtInfo : AopObject
    {
        /// <summary>
        /// 航班到达的准点率
        /// </summary>
        [XmlElement("arr_on_time")]
        public string ArrOnTime { get; set; }

        /// <summary>
        /// 航班平均到达延误时长，单位：分钟
        /// </summary>
        [XmlElement("avg_arr_delay")]
        public string AvgArrDelay { get; set; }

        /// <summary>
        /// 航班平均出发延误时长，单位：分钟
        /// </summary>
        [XmlElement("avg_dep_delay")]
        public string AvgDepDelay { get; set; }

        /// <summary>
        /// 航班取消率
        /// </summary>
        [XmlElement("cancel_pt")]
        public string CancelPt { get; set; }

        /// <summary>
        /// 是否有充电口，true:有，false:无
        /// </summary>
        [XmlElement("charging_port")]
        public string ChargingPort { get; set; }

        /// <summary>
        /// 航班廊桥率
        /// </summary>
        [XmlElement("covered_bridge")]
        public string CoveredBridge { get; set; }

        /// <summary>
        /// 航班出发的准点率
        /// </summary>
        [XmlElement("dep_on_time")]
        public string DepOnTime { get; set; }

        /// <summary>
        /// 是否有电视节目，true:有，false:无
        /// </summary>
        [XmlElement("tv")]
        public string Tv { get; set; }

        /// <summary>
        /// 是否有wifi，true:有，false:无
        /// </summary>
        [XmlElement("wifi")]
        public string Wifi { get; set; }
    }
}
