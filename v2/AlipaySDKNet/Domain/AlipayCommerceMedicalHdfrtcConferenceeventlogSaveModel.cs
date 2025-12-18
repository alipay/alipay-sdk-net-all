using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcConferenceeventlogSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcConferenceeventlogSaveModel : AopObject
    {
        /// <summary>
        /// 事件内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }

        /// <summary>
        /// 会议ID
        /// </summary>
        [XmlElement("video_conference_id")]
        public string VideoConferenceId { get; set; }
    }
}
