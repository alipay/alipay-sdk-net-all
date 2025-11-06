using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfrtcVideoconferenceCreateResponse : AopResponse
    {
        /// <summary>
        /// 视频会议ID
        /// </summary>
        [XmlElement("video_conference_id")]
        public long VideoConferenceId { get; set; }
    }
}
