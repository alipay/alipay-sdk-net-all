using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNdeviceWorkstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNdeviceWorkstatusQueryModel : AopObject
    {
        /// <summary>
        /// 碰一下设备SN标识
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备类型，主要描述当前碰一下设备类型，如N6E
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }
    }
}
