using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// RobbyOpenDeviceStatusQueryResponse.
    /// </summary>
    public class RobbyOpenDeviceStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("device_status_info")]
        public List<DeviceStatusInfo> Result { get; set; }
    }
}
