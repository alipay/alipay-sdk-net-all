using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServiceaiChathistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServiceaiChathistoryQueryModel : AopObject
    {
        /// <summary>
        /// 智能体ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 对话ID
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 最近历史会话时间
        /// </summary>
        [XmlElement("latest_time")]
        public long LatestTime { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 外部用户的唯一ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
