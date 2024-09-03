using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StreamContent Data Structure.
    /// </summary>
    [Serializable]
    public class StreamContent : AopObject
    {
        /// <summary>
        /// Continue  继续应答 Finish      完成 Interrupt  中断并给予兜底应答
        /// </summary>
        [XmlElement("reply_cmd")]
        public string ReplyCmd { get; set; }

        /// <summary>
        /// 单次推送的流式文本内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
