using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OdPredictionLineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OdPredictionLineInfo : AopObject
    {
        /// <summary>
        /// 客流预测任务对当前线路的操作类型,CREATE/UPDATE/DELETE
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 线路方向,枚举UP/DOWN
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 可扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 公交线路id，统一公交企业下应唯一
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路名称
        /// </summary>
        [XmlElement("line_name")]
        public string LineName { get; set; }

        /// <summary>
        /// 票价，单位:元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 线路营运时间(HH24:mm:ss)
        /// </summary>
        [XmlElement("service_time")]
        public string ServiceTime { get; set; }

        /// <summary>
        /// 线路对应站点列表
        /// </summary>
        [XmlArray("station_list")]
        [XmlArrayItem("station_info")]
        public List<StationInfo> StationList { get; set; }

        /// <summary>
        /// 线路交通类型
        /// </summary>
        [XmlElement("traffic_type")]
        public string TrafficType { get; set; }
    }
}
