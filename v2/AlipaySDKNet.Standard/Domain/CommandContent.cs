using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommandContent Data Structure.
    /// </summary>
    [Serializable]
    public class CommandContent : AopObject
    {
        /// <summary>
        /// 节能模式
        /// </summary>
        [XmlElement("energy_save_mode")]
        public string EnergySaveMode { get; set; }

        /// <summary>
        /// 电源开关
        /// </summary>
        [XmlElement("power_switch")]
        public string PowerSwitch { get; set; }

        /// <summary>
        /// 目标温度,单位：摄氏度
        /// </summary>
        [XmlElement("target_temperature")]
        public string TargetTemperature { get; set; }

        /// <summary>
        /// 风速
        /// </summary>
        [XmlElement("wind_speed")]
        public string WindSpeed { get; set; }

        /// <summary>
        /// 工作模式
        /// </summary>
        [XmlElement("work_mode")]
        public string WorkMode { get; set; }
    }
}
