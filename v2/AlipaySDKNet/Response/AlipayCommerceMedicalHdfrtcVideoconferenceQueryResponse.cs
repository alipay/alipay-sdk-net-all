using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferenceQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfrtcVideoconferenceQueryResponse : AopResponse
    {
        /// <summary>
        /// 会议信息
        /// </summary>
        [XmlElement("conference_info")]
        public ConferenceInfo ConferenceInfo { get; set; }

        /// <summary>
        /// 医生信息
        /// </summary>
        [XmlElement("doctor_info")]
        public DoctorDetails DoctorInfo { get; set; }

        /// <summary>
        /// 患者信息
        /// </summary>
        [XmlElement("patient_info")]
        public PatientDetails PatientInfo { get; set; }

        /// <summary>
        /// 音视频相关信息
        /// </summary>
        [XmlElement("rtc_base_info")]
        public RtcBaseInfo RtcBaseInfo { get; set; }
    }
}
