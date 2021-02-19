using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoInfo : AopObject
    {
        /// <summary>
        /// 最高优惠金额，仅针对折扣券
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 券金额，仅针对代金券
        /// </summary>
        [XmlElement("reduction_amount")]
        public string ReductionAmount { get; set; }

        /// <summary>
        /// 优惠额度，如3折券，返回0.7，仅针对折扣券
        /// </summary>
        [XmlElement("reduction_ratio")]
        public string ReductionRatio { get; set; }

        /// <summary>
        /// 减至金额，仅针对减至券
        /// </summary>
        [XmlElement("specified_amount")]
        public string SpecifiedAmount { get; set; }
    }
}
