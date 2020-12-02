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
        /// 最高优惠金额
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 代金券，券金额
        /// </summary>
        [XmlElement("reduction_amount")]
        public string ReductionAmount { get; set; }

        /// <summary>
        /// 优惠额度，如3折券，reduction_ratio=0.7
        /// </summary>
        [XmlElement("reduction_ratio")]
        public string ReductionRatio { get; set; }

        /// <summary>
        /// 特价券减至金额
        /// </summary>
        [XmlElement("specified_amount")]
        public string SpecifiedAmount { get; set; }
    }
}
