using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcConferencememberQuitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcConferencememberQuitModel : AopObject
    {
        /// <summary>
        /// 角色类型
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 医生空间ID
        /// </summary>
        [XmlElement("space_id")]
        public long SpaceId { get; set; }

        /// <summary>
        /// 好大夫侧用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 视频会议ID
        /// </summary>
        [XmlElement("video_conference_id")]
        public long VideoConferenceId { get; set; }
    }
}
