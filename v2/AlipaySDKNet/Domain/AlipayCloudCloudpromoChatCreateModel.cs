using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoChatCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoChatCreateModel : AopObject
    {
        /// <summary>
        /// 要进行会话聊天的智能体ID。
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 要进行会话聊天的智能体版本。智能体的版本号是”v1.0“，这里需要传入”1.0“。
        /// </summary>
        [XmlElement("agent_version")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 创建消息时的附加消息，获取消息时也会返回此附加消息。对应智能体应用中的自定义参数，即对话时的附加数据。
        /// </summary>
        [XmlElement("business_data")]
        public string BusinessData { get; set; }

        /// <summary>
        /// 会话 ID，即会话的唯一标识。
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 附加参数，通常用于特殊场景下指定一些必要参数供模型判断，例如指定经纬度，并询问智能体此位置的天气。
        /// </summary>
        [XmlElement("extra_params")]
        public ChatExtraParams ExtraParams { get; set; }

        /// <summary>
        /// 用于验证客户端身份的API-Key。你可以在百宝箱中生成API-Key，详细信息可参考<a href="https://alipaytbox.yuque.com/sxs0ba/huntb8/hhmpxnxaoxaulyil">链接</a>。
        /// </summary>
        [XmlElement("inc_access_id")]
        public string IncAccessId { get; set; }

        /// <summary>
        /// 压测标识。默认为 false。
        /// </summary>
        [XmlElement("load_test")]
        public bool LoadTest { get; set; }

        /// <summary>
        /// 用户发给智能体的问题内容。
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 重试标识。默认为 false。
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 标识当前与智能体对话的用户，由使用方自行定义、生成与维护。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
