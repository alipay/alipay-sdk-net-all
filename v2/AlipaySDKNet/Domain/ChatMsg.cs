using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatMsg Data Structure.
    /// </summary>
    [Serializable]
    public class ChatMsg : AopObject
    {
        /// <summary>
        /// 消息的具体内容
        /// </summary>
        [XmlElement("content")]
        public ChatContent Content { get; set; }

        /// <summary>
        /// 描述消息的类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
