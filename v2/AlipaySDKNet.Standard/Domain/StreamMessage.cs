using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StreamMessage Data Structure.
    /// </summary>
    [Serializable]
    public class StreamMessage : AopObject
    {
        /// <summary>
        /// 对话请求发起侧自定义生成的对话标识Id 当前字段已废弃(已废弃 通过chatId进行替代)
        /// </summary>
        [XmlElement("api_chat_id")]
        public string ApiChatId { get; set; }

        /// <summary>
        /// 对话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 单次推送的内容
        /// </summary>
        [XmlArray("contents")]
        [XmlArrayItem("content_unit")]
        public List<ContentUnit> Contents { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 识别到的意图编码
        /// </summary>
        [XmlElement("intention")]
        public string Intention { get; set; }

        /// <summary>
        /// 单次消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 用于区分同一个app下的机构
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 标识流式当前流式对话状态
        /// </summary>
        [XmlElement("reply_cmd")]
        public string ReplyCmd { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 推送轮次
        /// </summary>
        [XmlElement("turn")]
        public string Turn { get; set; }
    }
}
