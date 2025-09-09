using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PatientInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PatientInfo : AopObject
    {
        /// <summary>
        /// 过敏史
        /// </summary>
        [XmlElement("allergy_history")]
        public string AllergyHistory { get; set; }

        /// <summary>
        /// 家族病史
        /// </summary>
        [XmlElement("family_medical_history")]
        public string FamilyMedicalHistory { get; set; }

        /// <summary>
        /// 1肾功能 1-正常 2-异常
        /// </summary>
        [XmlElement("kidney_function")]
        public string KidneyFunction { get; set; }

        /// <summary>
        /// 哺乳 1-是 2-否
        /// </summary>
        [XmlElement("lactation_status")]
        public string LactationStatus { get; set; }

        /// <summary>
        /// 肝功能 1-正常 2-异常
        /// </summary>
        [XmlElement("liver_function")]
        public string LiverFunction { get; set; }

        /// <summary>
        /// 疾病史
        /// </summary>
        [XmlElement("medical_history")]
        public string MedicalHistory { get; set; }

        /// <summary>
        /// 过往史
        /// </summary>
        [XmlElement("past_history")]
        public string PastHistory { get; set; }

        /// <summary>
        /// 患者年龄
        /// </summary>
        [XmlElement("patient_age")]
        public string PatientAge { get; set; }

        /// <summary>
        /// 患者年龄单位 ○ 小于30天：天  ○ 30天~1年：月  ○ 大于等于1年：岁
        /// </summary>
        [XmlElement("patient_age_unit")]
        public string PatientAgeUnit { get; set; }

        /// <summary>
        /// 患者出身日期，格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("patient_birthday")]
        public string PatientBirthday { get; set; }

        /// <summary>
        /// 患者性别
        /// </summary>
        [XmlElement("patient_gender")]
        public string PatientGender { get; set; }

        /// <summary>
        /// 就诊人ID
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 妊娠 1-是 2-否
        /// </summary>
        [XmlElement("pregnancy_status")]
        public string PregnancyStatus { get; set; }

        /// <summary>
        /// 备孕 1-是 2-否
        /// </summary>
        [XmlElement("preparation_status")]
        public string PreparationStatus { get; set; }

        /// <summary>
        /// 体重，单位kg
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
