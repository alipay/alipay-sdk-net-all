using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AcChargePileRunTimeData Data Structure.
    /// </summary>
    [Serializable]
    public class AcChargePileRunTimeData : AopObject
    {
        /// <summary>
        /// 可下调容量
        /// </summary>
        [XmlElement("adjust_down")]
        public string AdjustDown { get; set; }

        /// <summary>
        /// 可上调容量
        /// </summary>
        [XmlElement("adjust_up")]
        public string AdjustUp { get; set; }

        /// <summary>
        /// 本次充电电量
        /// </summary>
        [XmlElement("cumulative_power")]
        public string CumulativePower { get; set; }

        /// <summary>
        /// A相电流，单位（A）
        /// </summary>
        [XmlElement("current_a")]
        public string CurrentA { get; set; }

        /// <summary>
        /// b相电流，单位（安培）
        /// </summary>
        [XmlElement("current_b")]
        public string CurrentB { get; set; }

        /// <summary>
        /// c相电流，单位（安培）
        /// </summary>
        [XmlElement("current_c")]
        public string CurrentC { get; set; }

        /// <summary>
        /// 充电桩设备Id
        /// </summary>
        [XmlElement("out_entity_id")]
        public string OutEntityId { get; set; }

        /// <summary>
        /// 功率，kw
        /// </summary>
        [XmlElement("power")]
        public string Power { get; set; }

        /// <summary>
        /// pwm占空比，百分比
        /// </summary>
        [XmlElement("pwm_duty_cycle")]
        public string PwmDutyCycle { get; set; }

        /// <summary>
        /// a相电压
        /// </summary>
        [XmlElement("voltage_a")]
        public string VoltageA { get; set; }

        /// <summary>
        /// b相电压
        /// </summary>
        [XmlElement("voltage_b")]
        public string VoltageB { get; set; }

        /// <summary>
        /// c相电压
        /// </summary>
        [XmlElement("voltage_c")]
        public string VoltageC { get; set; }
    }
}
