using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVAgentInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVAgentInfoDTO : AopObject
    {
        /// <summary>
        /// 二级机构名称
        /// </summary>
        [XmlElement("agent_sub_name")]
        public string AgentSubName { get; set; }

        /// <summary>
        /// 机构isv机构pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// isv机构sub pid
        /// </summary>
        [XmlElement("sub_pid")]
        public string SubPid { get; set; }
    }
}
