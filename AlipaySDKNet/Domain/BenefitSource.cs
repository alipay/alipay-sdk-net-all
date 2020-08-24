using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitSource Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitSource : AopObject
    {
        /// <summary>
        /// 来源类型，比如CAMPAIG
        /// </summary>
        [XmlElement("benefit_source_type")]
        public string BenefitSourceType { get; set; }

        /// <summary>
        /// 10000455203
        /// </summary>
        [XmlElement("benefit_source_value")]
        public string BenefitSourceValue { get; set; }
    }
}
