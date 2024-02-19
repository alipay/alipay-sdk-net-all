using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Recording Data Structure.
    /// </summary>
    [Serializable]
    public class Recording : AopObject
    {
        /// <summary>
        /// 坐席ID。
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 坐席名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 通话id
        /// </summary>
        [XmlElement("contact_id")]
        public string ContactId { get; set; }

        /// <summary>
        /// 录音时长，单位毫秒。
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 录音文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 录音文件的OSS下载地址，注意下载地址的过期时间，下载地址的有效期为1天。
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 录音开始时间，格式为Unix时间戳，单位毫秒。
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }
    }
}
