using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentStatisticDataItemOpenVO Data Structure.
    /// </summary>
    [Serializable]
    public class AgentStatisticDataItemOpenVO : AopObject
    {
        /// <summary>
        /// 统计数量结果
        /// </summary>
        [XmlElement("statistic_num")]
        public string StatisticNum { get; set; }

        /// <summary>
        /// 统计项名称
        /// </summary>
        [XmlElement("statistic_type")]
        public string StatisticType { get; set; }
    }
}
