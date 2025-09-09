using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcDevicestatusQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcDevicestatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备信息详情
        /// </summary>
        [XmlElement("device_info")]
        public EtcDeviceInfo DeviceInfo { get; set; }
    }
}
