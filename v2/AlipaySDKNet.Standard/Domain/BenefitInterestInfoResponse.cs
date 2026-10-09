using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitInterestInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitInterestInfoResponse : AopObject
    {
        /// <summary>
        /// 权益描述
        /// </summary>
        [XmlElement("benefit_description")]
        public string BenefitDescription { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 权益值，单位取决于类型，包含百分比等。
        /// </summary>
        [XmlElement("benefit_value")]
        public string BenefitValue { get; set; }
    }
}
