using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BotAnswer Data Structure.
    /// </summary>
    [Serializable]
    public class BotAnswer : AopObject
    {
        /// <summary>
        /// 机器人对话问答返回的澄清卡片详情
        /// </summary>
        [XmlArray("clarify_card")]
        [XmlArrayItem("answer_clarify_card_detail")]
        public List<AnswerClarifyCardDetail> ClarifyCard { get; set; }

        /// <summary>
        /// 机器人对话问答返回的推荐事项
        /// </summary>
        [XmlArray("item")]
        [XmlArrayItem("answer_item_detail")]
        public List<AnswerItemDetail> Item { get; set; }

        /// <summary>
        /// 机器人对话问答返回的知识点内容
        /// </summary>
        [XmlArray("knowledge")]
        [XmlArrayItem("answer_knowledge_detail")]
        public List<AnswerKnowledgeDetail> Knowledge { get; set; }

        /// <summary>
        /// 机器人对话问答返回的推荐服务
        /// </summary>
        [XmlArray("service")]
        [XmlArrayItem("answer_service_detail")]
        public List<AnswerServiceDetail> Service { get; set; }

        /// <summary>
        /// 机器人对话问答返回的流式详情
        /// </summary>
        [XmlElement("stream")]
        public AnswerStreamDetail Stream { get; set; }

        /// <summary>
        /// 机器人问答返回文本类型
        /// </summary>
        [XmlArray("text")]
        [XmlArrayItem("answer_text_detail")]
        public List<AnswerTextDetail> Text { get; set; }
    }
}
