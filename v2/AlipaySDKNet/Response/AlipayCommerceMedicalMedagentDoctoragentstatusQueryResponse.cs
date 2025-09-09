using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentDoctoragentstatusQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedagentDoctoragentstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// ai医生智能体状态信息数据
        /// </summary>
        [XmlElement("data")]
        public GetAgentStatusVO Data { get; set; }
    }
}
