using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HoloInsightDataQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class HoloInsightDataQueryResult : AopObject
    {
        /// <summary>
        /// tagkey列表
        /// </summary>
        [XmlArray("headers")]
        [XmlArrayItem("string")]
        public List<string> Headers { get; set; }

        /// <summary>
        /// pod cpu 利用率
        /// </summary>
        [XmlElement("metric")]
        public string Metric { get; set; }

        /// <summary>
        /// tags信息
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 时序值[{"period": 1698725520000,"value": "5.0"}]
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("holo_insight_data_result_value")]
        public List<HoloInsightDataResultValue> Values { get; set; }
    }
}
