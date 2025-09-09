using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AudioValueRequest Data Structure.
    /// </summary>
    [Serializable]
    public class AudioValueRequest : AopObject
    {
        /// <summary>
        /// aftsid，为蚂蚁中间件afts返回
        /// </summary>
        [XmlElement("audio_id")]
        public string AudioId { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("audio_name")]
        public string AudioName { get; set; }

        /// <summary>
        /// 音频大小,单位为B
        /// </summary>
        [XmlElement("audio_size")]
        public long AudioSize { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("audio_type")]
        public string AudioType { get; set; }
    }
}
