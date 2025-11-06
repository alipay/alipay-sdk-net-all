using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFPrescription Data Structure.
    /// </summary>
    [Serializable]
    public class HDFPrescription : AopObject
    {
        /// <summary>
        /// 审核时间
        /// </summary>
        [XmlElement("check_time")]
        public string CheckTime { get; set; }

        /// <summary>
        /// 开方医生ID
        /// </summary>
        [XmlElement("create_doctor_id")]
        public string CreateDoctorId { get; set; }

        /// <summary>
        /// 开方医生姓名
        /// </summary>
        [XmlElement("create_doctor_name")]
        public string CreateDoctorName { get; set; }

        /// <summary>
        /// 开方时间（ISO或yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 可含ICD10编码，多个用分隔符
        /// </summary>
        [XmlElement("diagnosis")]
        public string Diagnosis { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("drug_info")]
        [XmlArrayItem("h_d_f_drug_info")]
        public List<HDFDrugInfo> DrugInfo { get; set; }

        /// <summary>
        /// 处方过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 就诊科室
        /// </summary>
        [XmlElement("faculty_name")]
        public string FacultyName { get; set; }

        /// <summary>
        /// 合作方唯一处方标识
        /// </summary>
        [XmlElement("partner_prescription_id")]
        public string PartnerPrescriptionId { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_age")]
        public long PatientAge { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 患者性别
        /// </summary>
        [XmlElement("patient_sex")]
        public string PatientSex { get; set; }

        /// <summary>
        /// 审核药师ID
        /// </summary>
        [XmlElement("pharmacist_id")]
        public string PharmacistId { get; set; }

        /// <summary>
        /// 审核药师姓名
        /// </summary>
        [XmlElement("pharmacist_name")]
        public string PharmacistName { get; set; }

        /// <summary>
        /// 处方ID（系统唯一标识）
        /// </summary>
        [XmlElement("prescription_id")]
        public string PrescriptionId { get; set; }

        /// <summary>
        /// 处方单补充说明
        /// </summary>
        [XmlElement("prescription_note")]
        public string PrescriptionNote { get; set; }

        /// <summary>
        /// 单位kg
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
