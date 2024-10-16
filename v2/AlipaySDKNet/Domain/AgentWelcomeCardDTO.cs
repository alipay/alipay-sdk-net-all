using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentWelcomeCardDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AgentWelcomeCardDTO : AopObject
    {
        /// <summary>
        /// 智能体名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [XmlElement("card_icon")]
        public string CardIcon { get; set; }

        /// <summary>
        /// 口号
        /// </summary>
        [XmlElement("card_slogan")]
        public string CardSlogan { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        [XmlElement("intro_desc")]
        public string IntroDesc { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("intro_title")]
        public string IntroTitle { get; set; }

        /// <summary>
        /// 推荐问题
        /// </summary>
        [XmlArray("pre_question")]
        [XmlArrayItem("string")]
        public List<string> PreQuestion { get; set; }
    }
}
