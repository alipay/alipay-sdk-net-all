using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTerminalEdgecloudHeyagentApplyResponse.
    /// </summary>
    public class AlipayTerminalEdgecloudHeyagentApplyResponse : AopResponse
    {
        /// <summary>
        /// 本次启动云渲染会话ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }
    }
}
