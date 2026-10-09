using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DcChargePileRunTimeData Data Structure.
    /// </summary>
    [Serializable]
    public class DcChargePileRunTimeData : AopObject
    {
        /// <summary>
        /// 可下调容量，单位KW
        /// </summary>
        [XmlElement("adjust_down")]
        public string AdjustDown { get; set; }

        /// <summary>
        /// 可上调容量，单位KW
        /// </summary>
        [XmlElement("adjust_up")]
        public string AdjustUp { get; set; }

        /// <summary>
        /// 充电电量，单位KWH
        /// </summary>
        [XmlElement("cumulative_power")]
        public string CumulativePower { get; set; }

        /// <summary>
        /// 输出电流，单位（A）
        /// </summary>
        [XmlElement("output_current")]
        public string OutputCurrent { get; set; }

        /// <summary>
        /// 输出电压，单位（V）
        /// </summary>
        [XmlElement("output_voltage")]
        public string OutputVoltage { get; set; }

        /// <summary>
        /// 功率，单位 kw
        /// </summary>
        [XmlElement("power")]
        public string Power { get; set; }

        /// <summary>
        /// 剩余充电时长,单位 秒
        /// </summary>
        [XmlElement("remain_time")]
        public long RemainTime { get; set; }

        /// <summary>
        /// 请求电流，单位（A）
        /// </summary>
        [XmlElement("request_current")]
        public string RequestCurrent { get; set; }

        /// <summary>
        /// 申请电压，单位（V）
        /// </summary>
        [XmlElement("request_voltage")]
        public string RequestVoltage { get; set; }

        /// <summary>
        /// 车辆soc值，百分比
        /// </summary>
        [XmlElement("vehicle_soc_values")]
        public string VehicleSocValues { get; set; }

        /// <summary>
        /// 车辆vin码
        /// </summary>
        [XmlElement("vin_code")]
        public string VinCode { get; set; }
    }
}
