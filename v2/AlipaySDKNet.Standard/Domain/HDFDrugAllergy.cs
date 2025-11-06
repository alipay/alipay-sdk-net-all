using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFDrugAllergy Data Structure.
    /// </summary>
    [Serializable]
    public class HDFDrugAllergy : AopObject
    {
        /// <summary>
        /// 过敏描述
        /// </summary>
        [XmlElement("allergy_desc")]
        public string AllergyDesc { get; set; }

        /// <summary>
        /// 是/否/不清楚
        /// </summary>
        [XmlElement("is_allergy")]
        public string IsAllergy { get; set; }
    }
}
