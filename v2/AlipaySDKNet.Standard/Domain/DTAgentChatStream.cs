using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DTAgentChatStream Data Structure.
    /// </summary>
    [Serializable]
    public class DTAgentChatStream : AopObject
    {
        /// <summary>
        /// 输出的具体数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 流式输出类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
