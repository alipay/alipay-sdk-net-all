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
        /// 用户可以选择的周期付首次扣款日的开始时间
        /// </summary>
        [XmlElement("cycle_charge_start_time")]
        public string CycleChargeStartTime { get; set; }

        /// <summary>
        /// 周期计费类型
        /// </summary>
        [XmlElement("cycle_charge_type")]
        public string CycleChargeType { get; set; }

        /// <summary>
        /// 周期类型为CycleTypeEnum.DAY时使用、代表几天为一个周期
        /// </summary>
        [XmlElement("cycle_range")]
        public long CycleRange { get; set; }

        /// <summary>
        /// 周期类型，日、月或周
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
