using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CurrentChatAudio Data Structure.
    /// </summary>
    [Serializable]
    public class CurrentChatAudio : AopObject
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 音频文件详细信息
        /// </summary>
        [XmlElement("value")]
        public AudioValueRequest Value { get; set; }
    }
}
