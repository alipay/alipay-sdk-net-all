using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentAccountStates Data Structure.
    /// </summary>
    [Serializable]
    public class AgentAccountStates : AopObject
    {
        /// <summary>
        /// 坐席的ID
        /// </summary>
        [XmlElement("agent_id")]
        public long AgentId { get; set; }

        /// <summary>
        /// 坐席的名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 分级号码
        /// </summary>
        [XmlElement("dn")]
        public string Dn { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 坐席的登录名称
        /// </summary>
        [XmlElement("login_name")]
        public string LoginName { get; set; }

        /// <summary>
        /// 坐席状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 坐席状态持续时长
        /// </summary>
        [XmlElement("state_duration")]
        public string StateDuration { get; set; }
    }
}
