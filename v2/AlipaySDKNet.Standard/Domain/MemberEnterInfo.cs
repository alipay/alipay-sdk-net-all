using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberEnterInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MemberEnterInfo : AopObject
    {
        /// <summary>
        /// 医生是否进入过会议室
        /// </summary>
        [XmlElement("doctor_has_entered")]
        public bool DoctorHasEntered { get; set; }

        /// <summary>
        /// 医生是否在会议室中
        /// </summary>
        [XmlElement("doctor_is_present")]
        public bool DoctorIsPresent { get; set; }

        /// <summary>
        /// 患者是否在会议室中
        /// </summary>
        [XmlElement("patient_is_present")]
        public bool PatientIsPresent { get; set; }

        /// <summary>
        /// 视频会议ID
        /// </summary>
        [XmlElement("video_conference_id")]
        public long VideoConferenceId { get; set; }
    }
}
