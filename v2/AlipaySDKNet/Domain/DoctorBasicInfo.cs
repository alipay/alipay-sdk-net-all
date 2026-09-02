using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorBasicInfo : AopObject
    {
        /// <summary>
        /// 个人简介
        /// </summary>
        [XmlElement("brief_intro")]
        public string BriefIntro { get; set; }

        /// <summary>
        /// 行业医生id
        /// </summary>
        [XmlElement("doctor_inner_id")]
        public string DoctorInnerId { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 医生在线标识
        /// </summary>
        [XmlElement("doctor_online_flag")]
        public string DoctorOnlineFlag { get; set; }

        /// <summary>
        /// 好大夫医生id
        /// </summary>
        [XmlElement("hdf_doctor_id")]
        public string HdfDoctorId { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 综合病友推荐度
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
        [XmlArray("service_button_info_list")]
        [XmlArrayItem("service_button_info")]
        public List<ServiceButtonInfo> ServiceButtonInfoList { get; set; }

        /// <summary>
        /// 擅长技能描述
        /// </summary>
        [XmlElement("skilled_desc")]
        public string SkilledDesc { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("treatment_experience_list")]
        [XmlArrayItem("treat_experience_info")]
        public List<TreatExperienceInfo> TreatmentExperienceList { get; set; }
    }
}
