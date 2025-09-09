using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalRecordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalRecordInfo : AopObject
    {
        /// <summary>
        /// 过敏史内容
        /// </summary>
        [XmlElement("allergy")]
        public string Allergy { get; set; }

        /// <summary>
        /// 病情描述
        /// </summary>
        [XmlElement("condition_desc")]
        public string ConditionDesc { get; set; }

        /// <summary>
        /// 疾病描述
        /// </summary>
        [XmlElement("disease")]
        public string Disease { get; set; }

        /// <summary>
        /// 妊娠怀孕情况
        /// </summary>
        [XmlElement("gestation")]
        public string Gestation { get; set; }

        /// <summary>
        /// 身高描述
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 患者希望主诊医生提供的帮助
        /// </summary>
        [XmlElement("hope_help")]
        public string HopeHelp { get; set; }

        /// <summary>
        /// 曾就诊医院
        /// </summary>
        [XmlElement("hospital")]
        public string Hospital { get; set; }

        /// <summary>
        /// 重大病史
        /// </summary>
        [XmlElement("illness_history")]
        public string IllnessHistory { get; set; }

        /// <summary>
        /// 用药情况，当前正在使用的药物
        /// </summary>
        [XmlElement("medicine_condition")]
        public string MedicineCondition { get; set; }

        /// <summary>
        /// 患病时长
        /// </summary>
        [XmlElement("patient_course_time")]
        public string PatientCourseTime { get; set; }

        /// <summary>
        /// 体重描述
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
