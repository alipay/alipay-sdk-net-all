using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeAcpCreditinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeAcpCreditinfoQueryModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }
    }
}
