using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LineStationRealTimeVO Data Structure.
    /// </summary>
    [Serializable]
    public class LineStationRealTimeVO : AopObject
    {
        /// <summary>
        /// 线路主题色色值（十六进制色码）。
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("directions")]
        [XmlArrayItem("direction_v_o")]
        public List<DirectionVO> Directions { get; set; }

        /// <summary>
        /// 线路图标资源地址。
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 1号线
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
