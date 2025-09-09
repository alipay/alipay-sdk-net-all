using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechDtsparkChatQueryResponse.
    /// </summary>
    public class DatadigitalAnttechDtsparkChatQueryResponse : AopResponse
    {
        /// <summary>
        /// 会话流式输出结果
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// RAG引用文档详情
        /// </summary>
        [XmlArray("doc_infos")]
        [XmlArrayItem("document_info")]
        public List<DocumentInfo> DocInfos { get; set; }

        /// <summary>
        /// RAG引用FAQ详情
        /// </summary>
        [XmlArray("faqs")]
        [XmlArrayItem("faq_info")]
        public List<FaqInfo> Faqs { get; set; }

        /// <summary>
        /// 标识同一次多轮对话的id，session_id相同表示用户在同一会话中
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
