using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputScheduleLine Data Structure.
    /// </summary>
    [Serializable]
    public class InputScheduleLine : AopObject
    {
        /// <summary>
        /// 方向，参考方向枚举
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 聚合时间粒度，单位：分钟
        /// </summary>
        [XmlElement("time_span")]
        public long TimeSpan { get; set; }
    }
}
