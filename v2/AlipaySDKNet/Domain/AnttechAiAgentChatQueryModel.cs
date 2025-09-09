using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiAgentChatQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiAgentChatQueryModel : AopObject
    {
        /// <summary>
        /// 智能助手标识，由服务提供方发放，用于区别不同服务场景，每个智能助手的服务场景对应不同的配置，如访问的大模型类型、版本、依赖的知识库等等
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 提问内容
        /// </summary>
        [XmlArray("chat_contents")]
        [XmlArrayItem("d_t_agent_chat_content")]
        public List<DTAgentChatContent> ChatContents { get; set; }

        /// <summary>
        /// 是否使用心跳模式，为true返回event会包含心跳信息
        /// </summary>
        [XmlElement("heartbeat_mode")]
        public bool HeartbeatMode { get; set; }

        /// <summary>
        /// 业务场景参数，用于特殊场景的定制化入参
        /// </summary>
        [XmlElement("scene_param")]
        public DTAgentSceneParam SceneParam { get; set; }

        /// <summary>
        /// 标识同一次多轮对话的id，sessionId相同表示用户在同一会话中
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
