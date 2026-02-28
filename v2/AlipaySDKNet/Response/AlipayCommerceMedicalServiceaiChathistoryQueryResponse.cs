using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServiceaiChathistoryQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalServiceaiChathistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("llm_chat_history_v_o")]
        public List<LlmChatHistoryVO> ContentList { get; set; }

        /// <summary>
        /// 是否还有更多
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 最近历史会话时间
        /// </summary>
        [XmlElement("latest_time")]
        public long LatestTime { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
