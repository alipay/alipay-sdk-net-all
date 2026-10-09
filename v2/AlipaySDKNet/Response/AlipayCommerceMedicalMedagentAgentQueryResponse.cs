using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentAgentQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMedagentAgentQueryResponse : AopResponse
    {
        /// <summary>
        /// 智能体基本信息
        /// </summary>
        [XmlElement("data")]
        public GetAgentResult Data { get; set; }
    }
}
