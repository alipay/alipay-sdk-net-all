using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiseaseData Data Structure.
    /// </summary>
    [Serializable]
    public class DiseaseData : AopObject
    {
        /// <summary>
        /// 疾病id
        /// </summary>
        [XmlElement("disease_id")]
        public string DiseaseId { get; set; }

        /// <summary>
        /// 疾病名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }
    }
}
