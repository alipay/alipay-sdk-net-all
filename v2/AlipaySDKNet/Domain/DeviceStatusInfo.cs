using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceStatusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceStatusInfo : AopObject
    {
        /// <summary>
        /// 电量百分比（0-100）
        /// </summary>
        [XmlElement("battery_percent")]
        public long BatteryPercent { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("device_attrs")]
        [XmlArrayItem("device_attr")]
        public List<DeviceAttr> DeviceAttrs { get; set; }

        /// <summary>
        /// 机器人编号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 机器人状态，参考枚举值
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
