using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdIfaaDevicepubkeyQueryResponse.
    /// </summary>
    public class AlipaySecurityProdIfaaDevicepubkeyQueryResponse : AopResponse
    {
        /// <summary>
        /// 加密过的设备公钥信息。
        /// </summary>
        [XmlElement("device_key_info")]
        public string DeviceKeyInfo { get; set; }
    }
}
