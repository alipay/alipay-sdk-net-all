using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTerminalEdgecloudHeyagentCreateResponse.
    /// </summary>
    public class AlipayTerminalEdgecloudHeyagentCreateResponse : AopResponse
    {
        /// <summary>
        /// 本次绘话的ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }
    }
}
