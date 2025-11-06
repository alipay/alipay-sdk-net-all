using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFMedicalContent Data Structure.
    /// </summary>
    [Serializable]
    public class HDFMedicalContent : AopObject
    {
        /// <summary>
        /// 慢性病
        /// </summary>
        [XmlElement("chronic_disease")]
        public HDFChronicDisease ChronicDisease { get; set; }

        /// <summary>
        /// 病情描述
        /// </summary>
        [XmlElement("condition_desc")]
        public HDFConditiondesc ConditionDesc { get; set; }

        /// <summary>
        /// 疾病名称
        /// </summary>
        [XmlElement("disease")]
        public HDFDisease Disease { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("drug_allergy")]
        [XmlArrayItem("h_d_f_drug_allergy")]
        public List<HDFDrugAllergy> DrugAllergy { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("gestation_str")]
        [XmlArrayItem("h_d_f_gestation_str")]
        public List<HDFGestationStr> GestationStr { get; set; }

        /// <summary>
        /// 医院信息
        /// </summary>
        [XmlElement("hostpital")]
        public HdfHospital Hostpital { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("illness_history")]
        [XmlArrayItem("h_d_f_illness_history")]
        public List<HDFIllnessHistory> IllnessHistory { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("medicine_condition")]
        [XmlArrayItem("h_d_f_medicine_condition")]
        public List<HDFMedicineCondition> MedicineCondition { get; set; }

        /// <summary>
        /// 患病时间
        /// </summary>
        [XmlElement("patient_course_time")]
        public HDFPatientCourseTime PatientCourseTime { get; set; }

        /// <summary>
        /// 体格检查
        /// </summary>
        [XmlElement("record_base")]
        public HDFRecordBase RecordBase { get; set; }

        /// <summary>
        /// 诊疗经过
        /// </summary>
        [XmlElement("treatment_process")]
        public HDFHDFTreatmentProcess TreatmentProcess { get; set; }
    }
}
