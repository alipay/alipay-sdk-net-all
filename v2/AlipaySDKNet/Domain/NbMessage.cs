using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NbMessage Data Structure.
    /// </summary>
    [Serializable]
    public class NbMessage : AopObject
    {
        /// <summary>
        /// 创作者平台agentId
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 模型回答，如果media_type=text，answer为文本内容，如果media_type=image，answer为url列表
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 由应用定义的对话输入变量，具体内容参考青蓝平台应用定义，JSON格式的Map，详细解释青蓝平台应用调用接口请求参数解释- inputs
        /// </summary>
        [XmlElement("inputs")]
        public string Inputs { get; set; }

        /// <summary>
        /// 返回结果的类型
        /// </summary>
        [XmlElement("media_type")]
        public string MediaType { get; set; }

        /// <summary>
        /// 由应用定义的对话输入变量，具体内容参考AI 创作平台智能体定义，生成型应用必选，JSON格式的Map，详细解释AI 创作平台应用调用接口请求参数解释- inputs
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 下一步问题建议列表
        /// </summary>
        [XmlArray("related_questions")]
        [XmlArrayItem("string")]
        public List<string> RelatedQuestions { get; set; }

        /// <summary>
        /// 外部请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
