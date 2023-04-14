using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZMGOCycleFlexConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ZMGOCycleFlexConfig : AopObject
    {
        /// <summary>
        /// 周期灵活扣的费用名称
        /// </summary>
        [XmlElement("cycle_flex_withhold_fee_name")]
        public string CycleFlexWithholdFeeName { get; set; }

        /// <summary>
        /// 周期灵活扣单期扣款的最大额度
        /// </summary>
        [XmlElement("cycle_flex_withhold_max_price")]
        public string CycleFlexWithholdMaxPrice { get; set; }

        /// <summary>
        /// 周期灵活扣的总期数
        /// </summary>
        [XmlElement("cycle_flex_withhold_total_period_count")]
        public long CycleFlexWithholdTotalPeriodCount { get; set; }
    }
}
