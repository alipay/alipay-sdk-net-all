using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyDeviceDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyDeviceDataSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("device_data")]
        public List<DeviceData> List { get; set; }
    }
}
