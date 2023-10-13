using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardCycleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardCycleInfo : AopObject
    {
        /// <summary>
        /// 周期计费类型
        /// </summary>
        [XmlElement("cycle_charge_type")]
        public string CycleChargeType { get; set; }

        /// <summary>
        /// 周期类型，月或周
        /// </summary>
        [XmlElement("cycle_type")]
        public string CycleType { get; set; }

        /// <summary>
        /// 周期值。如月卡固定日期的计费方式，需要传入固定每个月的几号
        /// </summary>
        [XmlElement("cycle_value")]
        public long CycleValue { get; set; }
    }
}
