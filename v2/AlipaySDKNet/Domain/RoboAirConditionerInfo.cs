using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboAirConditionerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboAirConditionerInfo : AopObject
    {
        /// <summary>
        /// 是否有空调能力，1无，2有
        /// </summary>
        [XmlElement("air_ability")]
        public long AirAbility { get; set; }

        /// <summary>
        /// 最大空调温度，单位：度
        /// </summary>
        [XmlElement("max_temperature")]
        public string MaxTemperature { get; set; }

        /// <summary>
        /// 最小空调温度，单位：度
        /// </summary>
        [XmlElement("min_temperature")]
        public string MinTemperature { get; set; }

        /// <summary>
        /// 空调开启状态：1关闭，2开启
        /// </summary>
        [XmlElement("open_status")]
        public long OpenStatus { get; set; }

        /// <summary>
        /// 当前空调温度，单位：度
        /// </summary>
        [XmlElement("temperature")]
        public string Temperature { get; set; }
    }
}
