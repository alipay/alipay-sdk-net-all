using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeAcpZmcardurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeAcpZmcardurlQueryModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }
    }
}
