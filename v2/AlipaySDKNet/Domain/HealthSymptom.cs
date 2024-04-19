using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthSymptom Data Structure.
    /// </summary>
    [Serializable]
    public class HealthSymptom : AopObject
    {
        /// <summary>
        /// 症状id
        /// </summary>
        [XmlElement("symptom_id")]
        public string SymptomId { get; set; }

        /// <summary>
        /// 症状名称
        /// </summary>
        [XmlElement("symptom_name")]
        public string SymptomName { get; set; }
    }
}
