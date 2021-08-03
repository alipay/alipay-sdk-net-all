using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceRecordsSetResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceRecordsSetResponse : AopResponse
    {
        /// <summary>
        /// 设备档案
        /// </summary>
        [XmlElement("device_records")]
        public DeviceRecords DeviceRecords { get; set; }
    }
}
