using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RndBenefitRule Data Structure.
    /// </summary>
    [Serializable]
    public class RndBenefitRule : AopObject
    {
        /// <summary>
        /// 最大优惠
        /// </summary>
        [XmlElement("max_benefit")]
        public string MaxBenefit { get; set; }

        /// <summary>
        /// 最小优惠
        /// </summary>
        [XmlElement("min_benefit")]
        public string MinBenefit { get; set; }

        /// <summary>
        /// 该优惠区间所占比例,精度向下取整保留到两位小数，例如 0.01% 中的0.01
        /// </summary>
        [XmlElement("proportion")]
        public string Proportion { get; set; }
    }
}
