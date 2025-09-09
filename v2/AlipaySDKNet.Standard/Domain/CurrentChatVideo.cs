using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CurrentChatVideo Data Structure.
    /// </summary>
    [Serializable]
    public class CurrentChatVideo : AopObject
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 视频详细信息
        /// </summary>
        [XmlElement("value")]
        public VideoValueRequest Value { get; set; }
    }
}
