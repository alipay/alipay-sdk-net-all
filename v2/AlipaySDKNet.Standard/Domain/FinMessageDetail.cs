using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinMessageDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FinMessageDetail : AopObject
    {
        /// <summary>
        /// 流程节点内容
        /// </summary>
        [XmlElement("addition")]
        public string Addition { get; set; }

        /// <summary>
        /// 会话内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
