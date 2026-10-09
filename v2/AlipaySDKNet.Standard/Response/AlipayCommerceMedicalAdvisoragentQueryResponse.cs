using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAdvisoragentQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalAdvisoragentQueryResponse : AopResponse
    {
        /// <summary>
        /// 对话ID，传递本次场景交互的唯一对话ID
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 医生推荐列表
        /// </summary>
        [XmlElement("doctors")]
        public Doctors Doctors { get; set; }

        /// <summary>
        /// 会话ID，传递本次交互的唯一会话ID
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 建议列表
        /// </summary>
        [XmlElement("suggestions")]
        public string Suggestions { get; set; }

        /// <summary>
        /// 回复内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
