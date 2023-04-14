using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceGeofenceQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceGeofenceQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回线路上绑定的设备列表
        /// </summary>
        [XmlArray("bind_device")]
        [XmlArrayItem("string")]
        public List<string> BindDevice { get; set; }

        /// <summary>
        /// 地图围栏事件
        /// </summary>
        [XmlArray("fence_events")]
        [XmlArrayItem("fence_event")]
        public List<FenceEvent> FenceEvents { get; set; }
    }
}
