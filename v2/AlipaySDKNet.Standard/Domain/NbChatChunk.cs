using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NbChatChunk Data Structure.
    /// </summary>
    [Serializable]
    public class NbChatChunk : AopObject
    {
        /// <summary>
        /// 载荷的具体内容结构，JSON。具体内容参考文档：<a href="https://opendocs.alipay.com/pre-open/0cbnjv?pathHash=a0f51006">链接文本</a>
        /// </summary>
        [XmlElement("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 消息结构的细节类型，具体内容参考文档：<a href="https://opendocs.alipay.com/pre-open/0c2tup">链接文本</a>
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
