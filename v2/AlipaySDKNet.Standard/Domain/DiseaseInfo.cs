using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiseaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DiseaseInfo : AopObject
    {
        /// <summary>
        /// 诊断icd10编码
        /// </summary>
        [XmlElement("disease_code_icd_10")]
        public string DiseaseCodeIcd10 { get; set; }

        /// <summary>
        /// 诊断名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }

        /// <summary>
        /// 三方机构系统内部的处方编码
        /// </summary>
        [XmlElement("ext_disease_code")]
        public string ExtDiseaseCode { get; set; }
    }
}
