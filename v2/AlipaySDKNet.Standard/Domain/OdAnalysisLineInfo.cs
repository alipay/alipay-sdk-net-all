using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OdAnalysisLineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OdAnalysisLineInfo : AopObject
    {
        /// <summary>
        /// 线路方向（UP-上行，DOWN-下行）
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

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
        /// 聚合时间粒度，单位：分钟，只支持30/60
        /// </summary>
        [XmlElement("time_span")]
        public long TimeSpan { get; set; }
    }
}
