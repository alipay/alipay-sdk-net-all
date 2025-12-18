using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceStopModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcVideoconferenceStopModel : AopObject
    {
        /// <summary>
        /// 手机型号
        /// </summary>
        [XmlElement("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// 设备来源
        /// </summary>
        [XmlElement("device_source")]
        public string DeviceSource { get; set; }

        /// <summary>
        /// 视频结束类型 (ManualEnd:手动结束 TimeoutEnd:超时结束)
        /// </summary>
        [XmlElement("end_type")]
        public string EndType { get; set; }

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
        /// 用户ID
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
