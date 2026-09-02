using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAgentAuditSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentAuditSubmitModel : AopObject
    {
        /// <summary>
        /// 智能体功能介绍  
        /// </summary>
        [XmlElement("agent_desc")]
        public string AgentDesc { get; set; }

        /// <summary>
        /// 智能体的唯一标识
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 传文件ID(由 alipay.open.file.upload 返回，非 URL;图片格式 JPG/PNG
        /// </summary>
        [XmlElement("agent_logo")]
        public string AgentLogo { get; set; }

        /// <summary>
        /// 智能体名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }
    }
}
