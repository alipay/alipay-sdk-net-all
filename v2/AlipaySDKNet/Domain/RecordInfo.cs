using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecordInfo : AopObject
    {
        /// <summary>
        /// 会议时长（单位：秒）
        /// </summary>
        [XmlElement("conf_duration")]
        public long ConfDuration { get; set; }

        /// <summary>
        /// 视频实际时长（单位：秒）
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 文件大小 单位（字节）
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 录像ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 录播标题
        /// </summary>
        [XmlElement("record_title")]
        public string RecordTitle { get; set; }

        /// <summary>
        /// 录播播放地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
