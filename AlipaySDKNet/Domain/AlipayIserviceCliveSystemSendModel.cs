using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCliveSystemSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCliveSystemSendModel : AopObject
    {
        /// <summary>
        /// 系统消息内容，纯文本
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 渠道来源字段
        /// </summary>
        [XmlElement("src")]
        public string Src { get; set; }

        /// <summary>
        /// 渠道侧唯一用户标识
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }
    }
}
