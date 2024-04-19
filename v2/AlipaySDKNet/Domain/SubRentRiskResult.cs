using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubRentRiskResult Data Structure.
    /// </summary>
    [Serializable]
    public class SubRentRiskResult : AopObject
    {
        /// <summary>
        /// 基础履约风险
        /// </summary>
        [XmlElement("base_performance_risk")]
        public SubRentRiskItem BasePerformanceRisk { get; set; }

        /// <summary>
        /// 共租风险
        /// </summary>
        [XmlElement("multi_rent_risk")]
        public SubRentRiskItem MultiRentRisk { get; set; }

        /// <summary>
        /// 逾期风险
        /// </summary>
        [XmlElement("overdue_risk")]
        public SubRentRiskItem OverdueRisk { get; set; }
    }
}
