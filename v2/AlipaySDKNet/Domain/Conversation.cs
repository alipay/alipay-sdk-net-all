using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Conversation Data Structure.
    /// </summary>
    [Serializable]
    public class Conversation : AopObject
    {
        /// <summary>
        /// 对话内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 对话时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 对话角色
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
