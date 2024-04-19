using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardDiscountRecoverRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardDiscountRecoverRuleInfo : AopObject
    {
        /// <summary>
        /// 周期付
        /// </summary>
        [XmlElement("industry_solution_type")]
        public string IndustrySolutionType { get; set; }

        /// <summary>
        /// 满xxx期后允许取消
        /// </summary>
        [XmlElement("least_period")]
        public long LeastPeriod { get; set; }

        /// <summary>
        /// 需要优惠追回
        /// </summary>
        [XmlElement("recover_rule")]
        public string RecoverRule { get; set; }
    }
}
