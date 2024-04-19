using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItapDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItapDeviceInfo : AopObject
    {
        /// <summary>
        /// 固件版本
        /// </summary>
        [XmlElement("fw_version")]
        public string FwVersion { get; set; }

        /// <summary>
        /// 硬件版本
        /// </summary>
        [XmlElement("hw_version")]
        public string HwVersion { get; set; }

        /// <summary>
        /// 设备厂商名字
        /// </summary>
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 产品型号
        /// </summary>
        [XmlElement("model")]
        public string Model { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }
    }
}
