using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FlowStatsEntry Data Structure.
    /// </summary>
    [Serializable]
    public class FlowStatsEntry : AopObject
    {
        /// <summary>
        /// 访问量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 排名
        /// </summary>
        [XmlElement("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// 来源IP
        /// </summary>
        [XmlElement("source_ip")]
        public string SourceIp { get; set; }
    }
}
