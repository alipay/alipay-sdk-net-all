using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutpatientRecord Data Structure.
    /// </summary>
    [Serializable]
    public class OutpatientRecord : AopObject
    {
        /// <summary>
        /// 病人主诉
        /// </summary>
        [XmlElement("complaint")]
        public string Complaint { get; set; }

        /// <summary>
        /// 数据唯一标识，用于去重，下同
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 就诊日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 就诊科室
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 就诊医院
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 现病史
        /// </summary>
        [XmlElement("illness_history")]
        public string IllnessHistory { get; set; }

        /// <summary>
        /// 体格检查
        /// </summary>
        [XmlElement("physical_exam")]
        public string PhysicalExam { get; set; }

        /// <summary>
        /// 诊断*<中医诊断OR西医诊断疾病名称>
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 处理及意见
        /// </summary>
        [XmlElement("treatment_advice")]
        public string TreatmentAdvice { get; set; }

        /// <summary>
        /// 门诊类型 中医（CM）/西医（WM）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
