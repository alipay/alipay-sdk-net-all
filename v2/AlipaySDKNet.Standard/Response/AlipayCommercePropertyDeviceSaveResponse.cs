using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyDeviceSaveResponse.
    /// </summary>
    public class AlipayCommercePropertyDeviceSaveResponse : AopResponse
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }
    }
}
