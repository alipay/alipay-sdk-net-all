using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HdfCompletionChunk Data Structure.
    /// </summary>
    [Serializable]
    public class HdfCompletionChunk : AopObject
    {
        /// <summary>
        /// 载荷的具体内容结构，JSON。
        /// </summary>
        [XmlElement("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 消息结构的细节类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
