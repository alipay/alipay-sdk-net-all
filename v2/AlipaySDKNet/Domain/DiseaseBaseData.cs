using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiseaseBaseData Data Structure.
    /// </summary>
    [Serializable]
    public class DiseaseBaseData : AopObject
    {
        /// <summary>
        /// 临床症状
        /// </summary>
        [XmlElement("clinical_symptoms")]
        public string ClinicalSymptoms { get; set; }

        /// <summary>
        /// 是否常见病
        /// </summary>
        [XmlElement("common_disease")]
        public string CommonDisease { get; set; }

        /// <summary>
        /// 并发症
        /// </summary>
        [XmlElement("complication")]
        public string Complication { get; set; }

        /// <summary>
        /// 就诊科室
        /// </summary>
        [XmlElement("department_info")]
        public string DepartmentInfo { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        [XmlElement("disease_alias")]
        public string DiseaseAlias { get; set; }

        /// <summary>
        /// 疾病周期
        /// </summary>
        [XmlElement("disease_cycle")]
        public string DiseaseCycle { get; set; }

        /// <summary>
        /// 疾病描述
        /// </summary>
        [XmlElement("disease_introduction")]
        public string DiseaseIntroduction { get; set; }

        /// <summary>
        /// 疾病中文名称
        /// </summary>
        [XmlElement("disease_name_cn")]
        public string DiseaseNameCn { get; set; }

        /// <summary>
        /// 疾病英文名称
        /// </summary>
        [XmlElement("disease_name_en")]
        public string DiseaseNameEn { get; set; }

        /// <summary>
        /// 发病部位
        /// </summary>
        [XmlElement("disease_position")]
        public string DiseasePosition { get; set; }

        /// <summary>
        /// 症状
        /// </summary>
        [XmlElement("disease_symptom")]
        public string DiseaseSymptom { get; set; }

        /// <summary>
        /// 遗传性
        /// </summary>
        [XmlElement("genetic")]
        public string Genetic { get; set; }

        /// <summary>
        /// 传染性
        /// </summary>
        [XmlElement("infectivity")]
        public string Infectivity { get; set; }

        /// <summary>
        /// 多发人群
        /// </summary>
        [XmlElement("multiple_population")]
        public string MultiplePopulation { get; set; }
    }
}
