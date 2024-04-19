using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeTableLineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TimeTableLineInfo : AopObject
    {
        /// <summary>
        /// 自定义发车间隔列表，在指定时间区间内覆盖全局配置
        /// </summary>
        [XmlArray("customized_time_interval_list")]
        [XmlArrayItem("time_interval")]
        public List<TimeInterval> CustomizedTimeIntervalList { get; set; }

        /// <summary>
        /// 线路方向（UP-上行，DOWN-下行）
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 期望车次总数
        /// </summary>
        [XmlElement("expect_trip_count")]
        public long ExpectTripCount { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路ID，同一条线路的不同方向该值不同
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路Key，同一条线路的不同方向该值相同
        /// </summary>
        [XmlElement("line_key")]
        public string LineKey { get; set; }

        /// <summary>
        /// 全局最大发车间隔，单位：分钟
        /// </summary>
        [XmlElement("max_time_interval")]
        public long MaxTimeInterval { get; set; }

        /// <summary>
        /// 全局最小发车间隔，单位：分钟
        /// </summary>
        [XmlElement("min_time_interval")]
        public long MinTimeInterval { get; set; }

        /// <summary>
        /// 运营结束时间（hh24:mi:ss）
        /// </summary>
        [XmlElement("service_end_time")]
        public string ServiceEndTime { get; set; }

        /// <summary>
        /// 运营起始时间（hh24:mi:ss）
        /// </summary>
        [XmlElement("service_start_time")]
        public string ServiceStartTime { get; set; }

        /// <summary>
        /// 聚合时间粒度，单位：分钟，只支持30/60。如无需执行客流分析可不传
        /// </summary>
        [XmlElement("time_span")]
        public long TimeSpan { get; set; }

        /// <summary>
        /// 单车容量
        /// </summary>
        [XmlElement("vehicle_capacity")]
        public long VehicleCapacity { get; set; }
    }
}
