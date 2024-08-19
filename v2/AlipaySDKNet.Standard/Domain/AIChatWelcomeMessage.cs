using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AIChatWelcomeMessage Data Structure.
    /// </summary>
    [Serializable]
    public class AIChatWelcomeMessage : AopObject
    {
        /// <summary>
        /// 消息内容类型
        /// </summary>
        [XmlElement("msgtype")]
        public string Msgtype { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
