using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcVideoconferenceModifyModel : AopObject
    {
        /// <summary>
        /// 视频结束时间
        /// </summary>
        [XmlElement("real_end_time")]
        public string RealEndTime { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 视频状态
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
