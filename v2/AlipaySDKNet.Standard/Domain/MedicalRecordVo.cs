using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalRecordVo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalRecordVo : AopObject
    {
        /// <summary>
        /// 头像
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 好大夫医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 病程文字内容
        /// </summary>
        [XmlElement("medical_content")]
        public string MedicalContent { get; set; }

        /// <summary>
        /// 好大夫病程id
        /// </summary>
        [XmlElement("medical_record_id")]
        public string MedicalRecordId { get; set; }

        /// <summary>
        /// 病程title
        /// </summary>
        [XmlElement("medical_title")]
        public string MedicalTitle { get; set; }

        /// <summary>
        /// 是否三甲
        /// </summary>
        [XmlElement("third_class")]
        public bool ThirdClass { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
