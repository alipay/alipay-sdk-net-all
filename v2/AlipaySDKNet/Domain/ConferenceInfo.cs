using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConferenceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConferenceInfo : AopObject
    {
        /// <summary>
        /// 单位秒
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 单位秒
        /// </summary>
        [XmlElement("remaining_duration")]
        public long RemainingDuration { get; set; }

        /// <summary>
        /// 单位秒
        /// </summary>
        [XmlElement("remaining_scheduled_start_duration")]
        public long RemainingScheduledStartDuration { get; set; }

        /// <summary>
        /// 0: 未开始 1：进行中 2：已结束 3：已取消
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 视频会议ID
        /// </summary>
        [XmlElement("video_conference_id")]
        public long VideoConferenceId { get; set; }
    }
}
