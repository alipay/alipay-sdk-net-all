using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReplyPayload Data Structure.
    /// </summary>
    [Serializable]
    public class ReplyPayload : AopObject
    {
        /// <summary>
        /// 回复内容
        /// </summary>
        [XmlElement("reply_content")]
        public ReplyChatContent ReplyContent { get; set; }

        /// <summary>
        /// 回复类型
        /// </summary>
        [XmlElement("reply_type")]
        public string ReplyType { get; set; }
    }
}
