using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateDeviceUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateDeviceUnbindModel : AopObject
    {
        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }
    }
}
