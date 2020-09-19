using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitAmountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitAmountInfo : AopObject
    {
        /// <summary>
        /// 可用面额
        /// </summary>
        [XmlElement("benefit_available_amount")]
        public Amount BenefitAvailableAmount { get; set; }

        /// <summary>
        /// 总面额
        /// </summary>
        [XmlElement("benefit_total_amount")]
        public Amount BenefitTotalAmount { get; set; }
    }
}
