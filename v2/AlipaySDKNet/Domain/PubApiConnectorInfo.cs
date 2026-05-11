using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PubApiConnectorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PubApiConnectorInfo : AopObject
    {
        /// <summary>
        /// 充电枪id
        /// </summary>
        [XmlElement("connector_id")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 充电枪名称
        /// </summary>
        [XmlElement("connector_name")]
        public string ConnectorName { get; set; }

        /// <summary>
        /// 充电枪状态： 0：离网； 1：空闲； 2：占用（未充电）； 3：占用（充电中）； 4：占用（预约锁定）； 255：故障
        /// </summary>
        [XmlElement("connector_status")]
        public long ConnectorStatus { get; set; }

        /// <summary>
        /// 1:家用插座 (模式 2);2:交流接口插座 (模式 3, 连接方式 B);3:交流接口插头 (带枪线，模式 3, 连接方式 C);4:直流接口枪头 (带枪线，模式 4);5:无线充电座;6:其他
        /// </summary>
        [XmlElement("connector_type")]
        public long ConnectorType { get; set; }

        /// <summary>
        /// 额定电流 - 单位：A
        /// </summary>
        [XmlElement("current")]
        public string Current { get; set; }

        /// <summary>
        /// 车位号 - 停车场车位编号
        /// </summary>
        [XmlElement("park_no")]
        public string ParkNo { get; set; }

        /// <summary>
        /// 额定功率 - 单位：kW
        /// </summary>
        [XmlElement("power")]
        public string Power { get; set; }

        /// <summary>
        /// 快充属性
        /// </summary>
        [XmlElement("station_charger_type")]
        public string StationChargerType { get; set; }

        /// <summary>
        /// 额定电压下限 - 单位：V
        /// </summary>
        [XmlElement("voltage_lower_limits")]
        public long VoltageLowerLimits { get; set; }

        /// <summary>
        /// 额定电压上限 - 单位：V
        /// </summary>
        [XmlElement("voltage_upper_limits")]
        public long VoltageUpperLimits { get; set; }
    }
}
