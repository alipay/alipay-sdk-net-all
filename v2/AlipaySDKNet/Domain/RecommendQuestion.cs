using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendQuestion Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendQuestion : AopObject
    {
        /// <summary>
        /// 点击推荐问题的行为
        /// </summary>
        [XmlElement("click_action")]
        public string ClickAction { get; set; }

        /// <summary>
        /// 当点击行为为CHAT时，点击推荐问题会发送该文本
        /// </summary>
        [XmlElement("recommend_query")]
        public string RecommendQuery { get; set; }

        /// <summary>
        /// 推荐问题副标题，建议15字以内
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 推荐问题主标题，建议8个字以内
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 当点击行为为LINK时，点击后跳转的链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
