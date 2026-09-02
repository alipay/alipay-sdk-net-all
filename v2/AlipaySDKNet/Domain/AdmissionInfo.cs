using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdmissionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AdmissionInfo : AopObject
    {
        /// <summary>
        /// 病人主诉
        /// </summary>
        [XmlElement("complaint")]
        public string Complaint { get; set; }

        /// <summary>
        /// 既往病史
        /// </summary>
        [XmlElement("illness_history")]
        public string IllnessHistory { get; set; }

        /// <summary>
        /// 诊断结果
        /// </summary>
        [XmlElement("medicine_diagnosis")]
        public string MedicineDiagnosis { get; set; }

        /// <summary>
        /// 住院期间检查结果
        /// </summary>
        [XmlElement("physical_exam")]
        public string PhysicalExam { get; set; }

        /// <summary>
        /// 中医四诊，中医时才有
        /// </summary>
        [XmlElement("tcm_four_diagnosis")]
        public string TcmFourDiagnosis { get; set; }

        /// <summary>
        /// 中医诊断结果，中医时才有
        /// </summary>
        [XmlElement("traditional_chinese_medicine_diagnosis")]
        public string TraditionalChineseMedicineDiagnosis { get; set; }

        /// <summary>
        /// 处理及意见
        /// </summary>
        [XmlElement("treatment_advice")]
        public string TreatmentAdvice { get; set; }
    }
}
