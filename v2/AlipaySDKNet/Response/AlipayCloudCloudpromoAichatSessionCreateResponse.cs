using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatSessionCreateResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAichatSessionCreateResponse : AopResponse
    {
        /// <summary>
        /// 智能体内容，query_config.need_agent_content=true时返回
        /// </summary>
        [XmlElement("agent_content")]
        public string AgentContent { get; set; }

        /// <summary>
        /// 智能体信息，query_config.need_agent_info=true时返回
        /// </summary>
        [XmlElement("agent_info")]
        public AIChatAgentInfo AgentInfo { get; set; }

        /// <summary>
        /// 用户行为习惯
        /// </summary>
        [XmlElement("customer_like")]
        public AIChatCustomerLike CustomerLike { get; set; }

        /// <summary>
        /// 猜你想问问题列表，query_config.need_guess_question=true时返回
        /// </summary>
        [XmlArray("guess_question_list")]
        [XmlArrayItem("string")]
        public List<string> GuessQuestionList { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 欢迎语信息,query_config.need_welcom_message=true时返回
        /// </summary>
        [XmlElement("welcome_message")]
        public AIChatWelcomeMessage WelcomeMessage { get; set; }
    }
}
