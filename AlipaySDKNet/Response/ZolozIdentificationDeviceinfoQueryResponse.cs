using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZolozIdentificationDeviceinfoQueryResponse.
    /// </summary>
    public class ZolozIdentificationDeviceinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// device_info
        /// </summary>
        [XmlElement("device_info")]
        public ZolozDeviceInfo DeviceInfo { get; set; }
    }
}
