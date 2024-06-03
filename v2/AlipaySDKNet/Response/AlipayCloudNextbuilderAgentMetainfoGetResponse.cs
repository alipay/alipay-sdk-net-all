using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudNextbuilderAgentMetainfoGetResponse.
    /// </summary>
    public class AlipayCloudNextbuilderAgentMetainfoGetResponse : AopResponse
    {
        /// <summary>
        /// 创作者平台agentId
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// AI创作平台agent名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// AI创作平台agent功能描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// agent图标
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// agent类型：chat/draw/completion
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 已上架的平台列表
        /// </summary>
        [XmlArray("platforms")]
        [XmlArrayItem("string")]
        public List<string> Platforms { get; set; }
    }
}
