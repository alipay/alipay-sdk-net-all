using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAnttechDtsparkConversationQueryResponse.
    /// </summary>
    public class DatadigitalAnttechDtsparkConversationQueryResponse : AopResponse
    {
        /// <summary>
        /// 历史会话消息详情：包含消息内容、是否点赞等字段
        /// </summary>
        [XmlArray("messages")]
        [XmlArrayItem("message_detail")]
        public List<MessageDetail> Messages { get; set; }
    }
}
