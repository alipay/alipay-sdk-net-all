using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalBasicInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalBasicInfoDTO : AopObject
    {
        /// <summary>
        /// 诊断信息
        /// </summary>
        [XmlElement("diagnosis_info")]
        public DiagnosisInfoDTO DiagnosisInfo { get; set; }

        /// <summary>
        /// 就诊科室
        /// </summary>
        [XmlElement("faculty_name")]
        public string FacultyName { get; set; }

        /// <summary>
        /// 就诊卡号
        /// </summary>
        [XmlElement("medical_card_no")]
        public string MedicalCardNo { get; set; }

        /// <summary>
        /// 开单医生信息
        /// </summary>
        [XmlElement("open_order_doctor_info")]
        public DoctorInfoDTO OpenOrderDoctorInfo { get; set; }

        /// <summary>
        /// 患者信息
        /// </summary>
        [XmlElement("patient_info")]
        public PatientInfoDTO PatientInfo { get; set; }
    }
}
