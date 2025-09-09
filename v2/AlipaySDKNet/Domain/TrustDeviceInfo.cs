using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrustDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrustDeviceInfo : AopObject
    {
        /// <summary>
        /// 是否可调节
        /// </summary>
        [XmlElement("adjustable")]
        public bool Adjustable { get; set; }

        /// <summary>
        /// 充电设备类型
        /// </summary>
        [XmlElement("charge_device_type")]
        public string ChargeDeviceType { get; set; }

        /// <summary>
        /// 充电接口信息列表
        /// </summary>
        [XmlArray("connector_infos")]
        [XmlArrayItem("charge_connector_info")]
        public List<ChargeConnectorInfo> ConnectorInfos { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 用电户号
        /// </summary>
        [XmlElement("electric_account")]
        public string ElectricAccount { get; set; }

        /// <summary>
        /// 电表号
        /// </summary>
        [XmlElement("electric_meter_no")]
        public string ElectricMeterNo { get; set; }

        /// <summary>
        /// 设备生产商企业信息
        /// </summary>
        [XmlElement("manufacturer")]
        public EntityEnterpriseInfo Manufacturer { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [XmlElement("operate_status")]
        public string OperateStatus { get; set; }

        /// <summary>
        /// 额定功率，单位kw
        /// </summary>
        [XmlElement("rated_power")]
        public string RatedPower { get; set; }
    }
}
