using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FlowProtocol Data Structure.
    /// </summary>
    [Serializable]
    public class FlowProtocol : AopObject
    {
        /// <summary>
        /// 用户协议
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 内容样式
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("protocol_version")]
        public string ProtocolVersion { get; set; }
    }
}
