using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentStatisticsGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedagentStatisticsGetResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("data")]
        public AgentStatisticDataOpenVO Data { get; set; }
    }
}
