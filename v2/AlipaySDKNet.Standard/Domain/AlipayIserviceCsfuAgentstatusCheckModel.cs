using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCsfuAgentstatusCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCsfuAgentstatusCheckModel : AopObject
    {
        /// <summary>
        /// 坐席code标识
        /// </summary>
        [XmlElement("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 坐席所属租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
