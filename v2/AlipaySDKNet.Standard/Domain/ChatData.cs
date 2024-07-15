using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatData Data Structure.
    /// </summary>
    [Serializable]
    public class ChatData : AopObject
    {
        /// <summary>
        /// 答案的具体内容
        /// </summary>
        [XmlElement("chunk")]
        public ChatChunk Chunk { get; set; }

        /// <summary>
        /// 问答处理报错
        /// </summary>
        [XmlElement("error")]
        public ChatError Error { get; set; }

        /// <summary>
        /// 答案header信息，当type == header时该字段非空
        /// </summary>
        [XmlElement("header")]
        public ChatHeader Header { get; set; }

        /// <summary>
        /// 答案类型 当type == header时，展示header内容 当type == chunk时，展示chunk内容 当type == error时，展示error内容 当type == revoke时，展示revoke内容
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
