using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAssistantPresetquestionConsultResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAssistantPresetquestionConsultResponse : AopResponse
    {
        /// <summary>
        /// 回答内容
        /// </summary>
        [XmlElement("answer_content")]
        public string AnswerContent { get; set; }

        /// <summary>
        /// 询问时间
        /// </summary>
        [XmlElement("ask_time")]
        public string AskTime { get; set; }

        /// <summary>
        /// 客户的名称标识，用来标识本次对话的客户身份，必须传，进而在历史会话查询是可以通过用户身份查询对应的历史会话
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 当前这条消息的请求唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 会话唯一标识，用来表是否是同一个会话，用户传递时使用用户的标识，没有传递时系统自动生成会话id进行标识
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 建议的引导问题
        /// </summary>
        [XmlArray("suggestion_questions")]
        [XmlArrayItem("preset_quesiton")]
        public List<PresetQuesiton> SuggestionQuestions { get; set; }
    }
}
