using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmOlsChatrecordQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmOlsChatrecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 客服id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 客服昵称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 多个层级类目信息
        /// </summary>
        [XmlElement("categories")]
        public string Categories { get; set; }

        /// <summary>
        /// 在线技能组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 在线技能组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 聊天消息列表
        /// </summary>
        [XmlArray("messages")]
        [XmlArrayItem("chat_message")]
        public List<ChatMessage> Messages { get; set; }

        /// <summary>
        /// 满意度。 0：非常满意 1：满意 2：一般 3：不满意 4：非常不满意
        /// </summary>
        [XmlElement("satisfaction")]
        public string Satisfaction { get; set; }

        /// <summary>
        /// 服务记录状态。1：待处理 2：暂存 3：完结 4：废除 5：无效 6：未知
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 在线服务时长，单位秒
        /// </summary>
        [XmlElement("talk_duration")]
        public long TalkDuration { get; set; }

        /// <summary>
        /// 访客归属地
        /// </summary>
        [XmlElement("visitor_province")]
        public string VisitorProvince { get; set; }
    }
}
