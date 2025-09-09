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
        /// 拒识等答案处理，当出现了拒绝识别等回复时候，出该种类型的答案
        /// </summary>
        [XmlElement("error")]
        public ChatError Error { get; set; }

        /// <summary>
        /// 答案header信息，当type == header时该字段非空
        /// </summary>
        [XmlElement("header")]
        public ChatHeader Header { get; set; }

        /// <summary>
        /// 答案格式,header:第一次返回内容在header字段中，会包含原始问题和请求的requestID；chunk:实际的问答内容，流式进行返回；error:报错的类型返回报错的信息
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
