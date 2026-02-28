using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalDoctoragentCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalDoctoragentCreateResponse : AopResponse
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 下游头像id
        /// </summary>
        [XmlElement("avatar_id")]
        public string AvatarId { get; set; }

        /// <summary>
        /// 配置id
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }
    }
}
