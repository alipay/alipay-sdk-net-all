using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorData Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorData : AopObject
    {
        /// <summary>
        /// 学术职称
        /// </summary>
        [XmlElement("academic_title")]
        public string AcademicTitle { get; set; }

        /// <summary>
        /// 医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生个人介绍
        /// </summary>
        [XmlElement("doctor_introduction")]
        public string DoctorIntroduction { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 医生头像
        /// </summary>
        [XmlElement("doctor_photo")]
        public string DoctorPhoto { get; set; }

        /// <summary>
        /// 医生标签
        /// </summary>
        [XmlElement("doctor_tag")]
        public string DoctorTag { get; set; }

        /// <summary>
        /// 医生挂号服务跳转链接
        /// </summary>
        [XmlElement("doctor_url")]
        public string DoctorUrl { get; set; }

        /// <summary>
        /// 执医年限
        /// </summary>
        [XmlElement("medical_practice_years")]
        public string MedicalPracticeYears { get; set; }

        /// <summary>
        /// 擅长疾病
        /// </summary>
        [XmlArray("skilled_disease")]
        [XmlArrayItem("disease_data")]
        public List<DiseaseData> SkilledDisease { get; set; }

        /// <summary>
        /// 擅长疾病描述
        /// </summary>
        [XmlElement("skilled_disease_desc")]
        public string SkilledDiseaseDesc { get; set; }

        /// <summary>
        /// 工作信息
        /// </summary>
        [XmlArray("work_info")]
        [XmlArrayItem("doctor_work_info")]
        public List<DoctorWorkInfo> WorkInfo { get; set; }

        /// <summary>
        /// 排班时间
        /// </summary>
        [XmlElement("work_time")]
        public string WorkTime { get; set; }
    }
}
