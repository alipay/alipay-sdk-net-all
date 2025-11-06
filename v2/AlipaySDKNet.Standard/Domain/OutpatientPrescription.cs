using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutpatientPrescription Data Structure.
    /// </summary>
    [Serializable]
    public class OutpatientPrescription : AopObject
    {
        /// <summary>
        /// 数据唯一标识，用于去重
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 开方时间
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
        /// 临床诊断
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 中医
        /// </summary>
        [XmlElement("traditional_chinese_medicine")]
        public TraditionalChineseMedicine TraditionalChineseMedicine { get; set; }

        /// <summary>
        /// 处方类型（中医，西医）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 西医
        /// </summary>
        [XmlElement("western_medicine")]
        public WesternMedicine WesternMedicine { get; set; }
    }
}
