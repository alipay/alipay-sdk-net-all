using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiAgentChatQueryResponse.
    /// </summary>
    public class AnttechAiAgentChatQueryResponse : AopResponse
    {
        /// <summary>
        /// 最终完整结果的内容
        /// </summary>
        [XmlElement("chat_result")]
        public DTAgentChatResult ChatResult { get; set; }

        /// <summary>
        /// 输出状态
        /// </summary>
        [XmlElement("process_status")]
        public string ProcessStatus { get; set; }

        /// <summary>
        /// 流式输出结构
        /// </summary>
        [XmlElement("stream")]
        public DTAgentChatStream Stream { get; set; }

        /// <summary>
        /// 会话结果标签
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("d_t_agent_tag_info")]
        public List<DTAgentTagInfo> Tags { get; set; }
    }
}
