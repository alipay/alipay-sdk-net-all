using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoiceContent Data Structure.
    /// </summary>
    [Serializable]
    public class VoiceContent : AopObject
    {
        /// <summary>
        /// 发音人
        /// </summary>
        [XmlElement("speaker")]
        public string Speaker { get; set; }

        /// <summary>
        /// 语音触点
        /// </summary>
        [XmlElement("touchpoint_type")]
        public string TouchpointType { get; set; }

        /// <summary>
        /// 语音播报文案
        /// </summary>
        [XmlElement("voice_text")]
        public string VoiceText { get; set; }
    }
}
