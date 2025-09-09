using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CurrentChatAudios Data Structure.
    /// </summary>
    [Serializable]
    public class CurrentChatAudios : AopObject
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 音频文件信息
        /// </summary>
        [XmlArray("value")]
        [XmlArrayItem("audio_value_request")]
        public List<AudioValueRequest> Value { get; set; }
    }
}
