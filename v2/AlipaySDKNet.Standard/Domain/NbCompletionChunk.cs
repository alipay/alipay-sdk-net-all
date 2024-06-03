using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NbCompletionChunk Data Structure.
    /// </summary>
    [Serializable]
    public class NbCompletionChunk : AopObject
    {
        /// <summary>
        /// 载荷的具体内容结构，JSON。具体内容参考文档：<a href="https://opendocs.alipay.com/pre-open/0cbosj?pathHash=65a79d8d">链接文本</a>
        /// </summary>
        [XmlElement("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 消息结构的细节类型，具体内容参考文档：<a href="https://opendocs.alipay.com/pre-open/0c5two">链接文本</a>
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
