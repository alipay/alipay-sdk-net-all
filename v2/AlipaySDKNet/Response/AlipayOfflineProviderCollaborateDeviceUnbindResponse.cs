using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateDeviceUnbindResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateDeviceUnbindResponse : AopResponse
    {
        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }
    }
}
