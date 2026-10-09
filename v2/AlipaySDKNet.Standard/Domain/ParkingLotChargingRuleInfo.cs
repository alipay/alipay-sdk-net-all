using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParkingLotChargingRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ParkingLotChargingRuleInfo : AopObject
    {
        /// <summary>
        /// 停车收费时间段，输入24小时制的小时时间段格式:  开始时间-结束时间, 结束时间必须大于开始时间 时间取值范围：0到24
        /// </summary>
        [XmlElement("charging_period")]
        public string ChargingPeriod { get; set; }

        /// <summary>
        /// 计费策略； UP：向上取整 DOMN：向下取整
        /// </summary>
        [XmlElement("charging_strategy")]
        public string ChargingStrategy { get; set; }

        /// <summary>
        /// 跳费金额 单位元
        /// </summary>
        [XmlElement("charging_unit_fee")]
        public string ChargingUnitFee { get; set; }

        /// <summary>
        /// 跳费间隔分钟数
        /// </summary>
        [XmlElement("charging_unit_minutes")]
        public string ChargingUnitMinutes { get; set; }

        /// <summary>
        /// 超时是否顺延到下个计费区间
        /// </summary>
        [XmlElement("enable_rollover_charge_period")]
        public bool EnableRolloverChargePeriod { get; set; }

        /// <summary>
        /// 首段计费周期分钟数
        /// </summary>
        [XmlElement("first_charging_span_minutes")]
        public string FirstChargingSpanMinutes { get; set; }

        /// <summary>
        /// 首段计费周期跳费金额 单位: 元
        /// </summary>
        [XmlElement("first_charging_unit_fee")]
        public string FirstChargingUnitFee { get; set; }

        /// <summary>
        /// 首段计费周期跳费间隔 单位分钟
        /// </summary>
        [XmlElement("first_charging_unit_minutes")]
        public string FirstChargingUnitMinutes { get; set; }

        /// <summary>
        /// 入场免费时间 单位:分钟
        /// </summary>
        [XmlElement("free_enter_minutes")]
        public string FreeEnterMinutes { get; set; }

        /// <summary>
        /// 离场免费时间 单位:分钟
        /// </summary>
        [XmlElement("free_exit_minutes")]
        public string FreeExitMinutes { get; set; }

        /// <summary>
        /// 日封顶金额 单位: 元
        /// </summary>
        [XmlElement("max_fee_per_day")]
        public string MaxFeePerDay { get; set; }
    }
}
