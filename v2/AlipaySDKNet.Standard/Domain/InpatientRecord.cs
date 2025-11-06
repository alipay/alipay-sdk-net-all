using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InpatientRecord Data Structure.
    /// </summary>
    [Serializable]
    public class InpatientRecord : AopObject
    {
        /// <summary>
        /// 数据唯一标识，用于去重
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 实际住院天数
        /// </summary>
        [XmlElement("days")]
        public string Days { get; set; }

        /// <summary>
        /// 入院科室
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 就诊医院
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 入院时间
        /// </summary>
        [XmlElement("in_date")]
        public string InDate { get; set; }

        /// <summary>
        /// 出院时间
        /// </summary>
        [XmlElement("recovery_date")]
        public string RecoveryDate { get; set; }

        /// <summary>
        /// 出院科室
        /// </summary>
        [XmlElement("recovery_department_name")]
        public string RecoveryDepartmentName { get; set; }

        /// <summary>
        /// 出院主要诊断
        /// </summary>
        [XmlElement("recovery_memo")]
        public string RecoveryMemo { get; set; }

        /// <summary>
        /// 手术信息
        /// </summary>
        [XmlElement("surgery_info")]
        public SurgeryInfo SurgeryInfo { get; set; }

        /// <summary>
        /// 出院诊断-中医病名名称
        /// </summary>
        [XmlElement("traditional_chinese_medicine_diagnosis")]
        public string TraditionalChineseMedicineDiagnosis { get; set; }

        /// <summary>
        /// 入院途径、入院诊断名称
        /// </summary>
        [XmlElement("way")]
        public string Way { get; set; }

        /// <summary>
        /// 出院诊断-西医诊断名称
        /// </summary>
        [XmlElement("western_medicine_diagnosis")]
        public string WesternMedicineDiagnosis { get; set; }
    }
}
