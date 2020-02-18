using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDeviceInitializeResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodDeviceInitializeResponse : AopResponse
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }
    }
}
