using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StreamResponse Data Structure.
    /// </summary>
    [Serializable]
    public class StreamResponse : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 业务信息，和入参映射
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 对话ID
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("contents")]
        [XmlArrayItem("a_i_stream_content")]
        public List<AIStreamContent> Contents { get; set; }

        /// <summary>
        /// 全局业务信息
        /// </summary>
        [XmlElement("out_biz_content")]
        public string OutBizContent { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 推送轮次
        /// </summary>
        [XmlElement("turn")]
        public long Turn { get; set; }
    }
}
