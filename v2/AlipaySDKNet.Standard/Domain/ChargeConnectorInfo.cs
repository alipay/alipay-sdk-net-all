using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargeConnectorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeConnectorInfo : AopObject
    {
        /// <summary>
        /// 充电设备接口ID
        /// </summary>
        [XmlElement("connector_id")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 充电设备接口名称
        /// </summary>
        [XmlElement("connector_name")]
        public string ConnectorName { get; set; }

        /// <summary>
        /// 充电设备接口类型
        /// </summary>
        [XmlElement("connector_type")]
        public string ConnectorType { get; set; }

        /// <summary>
        /// 额定电流，单位A，精确到小数点后一位
        /// </summary>
        [XmlElement("current")]
        public string Current { get; set; }

        /// <summary>
        /// 国家标准： 国标2011、国标2015
        /// </summary>
        [XmlElement("national_standard")]
        public string NationalStandard { get; set; }

        /// <summary>
        /// 额定功率，单位kw，保留?数点后2位
        /// </summary>
        [XmlElement("power")]
        public string Power { get; set; }

        /// <summary>
        /// 额定电压下限，单位：V，精确到小数点后一位
        /// </summary>
        [XmlElement("voltage_lower_limit")]
        public string VoltageLowerLimit { get; set; }

        /// <summary>
        /// 额定电压，单位：V，精确到小数点后一位
        /// </summary>
        [XmlElement("voltage_upper_limit")]
        public string VoltageUpperLimit { get; set; }
    }
}
