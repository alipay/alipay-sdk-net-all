using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudNextbuilderAgentMessageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudNextbuilderAgentMessageQueryModel : AopObject
    {
        /// <summary>
        /// AI创作平台agentId
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 顺序（升序or降序）
        /// </summary>
        [XmlElement("order")]
        public string Order { get; set; }

        /// <summary>
        /// 排序的属性
        /// </summary>
        [XmlElement("order_by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// 当前页码，从1开始，默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
