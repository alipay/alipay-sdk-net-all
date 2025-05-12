using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GateDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GateDeviceInfo : AopObject
    {
        /// <summary>
        /// 开卡平台支持的门禁厂商，平台会根据小区和门禁厂商，决策对应的开卡设备
        /// </summary>
        [XmlElement("gate_supplier_code")]
        public string GateSupplierCode { get; set; }

        /// <summary>
        /// 门禁厂商管理系统中的真实设备SN
        /// </summary>
        [XmlElement("sys_device_id")]
        public string SysDeviceId { get; set; }
    }
}
