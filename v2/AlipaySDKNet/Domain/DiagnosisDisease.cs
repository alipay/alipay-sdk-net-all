using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiagnosisDisease Data Structure.
    /// </summary>
    [Serializable]
    public class DiagnosisDisease : AopObject
    {
        /// <summary>
        /// 药品列表
        /// </summary>
        [XmlArray("drug_item_infos")]
        [XmlArrayItem("drug_item_info")]
        public List<DrugItemInfo> DrugItemInfos { get; set; }

        /// <summary>
        /// 遵从icd10规范
        /// </summary>
        [XmlElement("icd_code")]
        public string IcdCode { get; set; }

        /// <summary>
        /// icd名称
        /// </summary>
        [XmlElement("icd_name")]
        public string IcdName { get; set; }

        /// <summary>
        /// 症状列表
        /// </summary>
        [XmlArray("symptoms")]
        [XmlArrayItem("health_symptom")]
        public List<HealthSymptom> Symptoms { get; set; }
    }
}
