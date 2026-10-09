using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyDeviceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyDeviceDeleteModel : AopObject
    {
        /// <summary>
        /// device_id及out_device_id二选一，同时填写时以device_id为准。
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// device_id及out_device_id二选一，同时填写时以device_id为准。
        /// </summary>
        [XmlElement("out_device_id")]
        public string OutDeviceId { get; set; }
    }
}
