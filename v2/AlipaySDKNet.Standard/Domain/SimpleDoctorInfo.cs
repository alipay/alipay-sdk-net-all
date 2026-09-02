using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SimpleDoctorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleDoctorInfo : AopObject
    {
        /// <summary>
        /// 医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 医生在线标识，1：在线 0：不在线
        /// </summary>
        [XmlElement("doctor_online_flag")]
        public long DoctorOnlineFlag { get; set; }

        /// <summary>
        /// 病友推荐度，5分制
        /// </summary>
        [XmlElement("hot_rank")]
        public string HotRank { get; set; }

        /// <summary>
        /// 接诊量
        /// </summary>
        [XmlElement("medical_record_cnt")]
        public long MedicalRecordCnt { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("medical_record_disease_list")]
        [XmlArrayItem("doctor_record_disease")]
        public List<DoctorRecordDisease> MedicalRecordDiseaseList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_info")]
        [XmlArrayItem("doctor_service_info")]
        public List<DoctorServiceInfo> ServiceInfo { get; set; }
    }
}
