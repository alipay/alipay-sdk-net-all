using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTerminalEdgecloudHeyagentDataQueryResponse.
    /// </summary>
    public class AlipayTerminalEdgecloudHeyagentDataQueryResponse : AopResponse
    {
        /// <summary>
        /// agentId
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 页面dom数据
        /// </summary>
        [XmlElement("dom")]
        public string Dom { get; set; }
    }
}
