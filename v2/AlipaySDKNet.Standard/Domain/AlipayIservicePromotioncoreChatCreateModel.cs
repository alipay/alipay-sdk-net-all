using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIservicePromotioncoreChatCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIservicePromotioncoreChatCreateModel : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 历史对话记录
        /// </summary>
        [XmlElement("history")]
        public string History { get; set; }

        /// <summary>
        /// 消息id，用于幂等
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("message_info")]
        public string MessageInfo { get; set; }

        /// <summary>
        /// 返回类型
        /// </summary>
        [XmlElement("return_type")]
        public string ReturnType { get; set; }

        /// <summary>
        /// 场景 
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
