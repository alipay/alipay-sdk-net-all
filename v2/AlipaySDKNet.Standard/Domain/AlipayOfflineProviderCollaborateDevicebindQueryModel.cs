using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateDevicebindQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateDevicebindQueryModel : AopObject
    {
        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }
    }
}
