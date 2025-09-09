using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockTrafficQueryResponse.
    /// </summary>
    public class AntfortuneStockTrafficQueryResponse : AopResponse
    {
        /// <summary>
        /// 流量模式，当为空时表示是全量人群模式
        /// </summary>
        [XmlElement("traffic_mode")]
        public string TrafficMode { get; set; }

        /// <summary>
        /// 单元流量配比
        /// </summary>
        [XmlArray("units")]
        [XmlArrayItem("unit_traffic")]
        public List<UnitTraffic> Units { get; set; }
    }
}
