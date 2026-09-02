using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LineVO Data Structure.
    /// </summary>
    [Serializable]
    public class LineVO : AopObject
    {
        /// <summary>
        /// 线路主题色色值（十六进制色码）。
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 线路图标资源地址。
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 线路编码，用于实时查询的 lineCode 入参。
        /// </summary>
        [XmlElement("line_code")]
        public string LineCode { get; set; }

        /// <summary>
        /// 线路中文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("next_stations")]
        [XmlArrayItem("station_v_o")]
        public List<StationVO> NextStations { get; set; }
    }
}
