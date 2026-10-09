using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BreakCostsExemptRule Data Structure.
    /// </summary>
    [Serializable]
    public class BreakCostsExemptRule : AopObject
    {
        /// <summary>
        /// 购卡7天内退卡不收违约金
        /// </summary>
        [XmlElement("break_costs_7_days")]
        public string BreakCosts7Days { get; set; }

        /// <summary>
        /// 过期后不收取违约金
        /// </summary>
        [XmlElement("break_costs_expired")]
        public string BreakCostsExpired { get; set; }

        /// <summary>
        /// 01-支持核销免违约金
        /// </summary>
        [XmlElement("no_break_costs_flag")]
        public string NoBreakCostsFlag { get; set; }

        /// <summary>
        /// 支持用户核销10期后退卡免违约金（当为金额卡的话为10分，当为周期卡为10期，当为次卡时为10次）
        /// </summary>
        [XmlElement("no_break_costs_standard_value")]
        public string NoBreakCostsStandardValue { get; set; }
    }
}
