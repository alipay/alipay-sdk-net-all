using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiseaseHistory Data Structure.
    /// </summary>
    [Serializable]
    public class DiseaseHistory : AopObject
    {
        /// <summary>
        /// 确诊日期
        /// </summary>
        [XmlElement("diagnosis_date")]
        public string DiagnosisDate { get; set; }

        /// <summary>
        /// 疾病名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }
    }
}
