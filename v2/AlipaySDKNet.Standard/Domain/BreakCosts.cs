using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BreakCosts Data Structure.
    /// </summary>
    [Serializable]
    public class BreakCosts : AopObject
    {
        /// <summary>
        /// 收取剩余金额的15%作为违约金
        /// </summary>
        [XmlElement("break_costs_rate")]
        public string BreakCostsRate { get; set; }

        /// <summary>
        /// DamagesTypeEnum REMAIN_RATE：剩余比例;DEFAULT:默认不收违约金
        /// </summary>
        [XmlElement("break_costs_type")]
        public string BreakCostsType { get; set; }
    }
}
