using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpayChargeInitializeResponse.
    /// </summary>
    public class AlipayAipayNowpayChargeInitializeResponse : AopResponse
    {
        /// <summary>
        /// 配置入口二维码
        /// </summary>
        [XmlElement("configuration_qr_code")]
        public string ConfigurationQrCode { get; set; }

        /// <summary>
        /// 需要继续配置时返回
        /// </summary>
        [XmlElement("configuration_url")]
        public string ConfigurationUrl { get; set; }

        /// <summary>
        /// 已完成配置时返回
        /// </summary>
        [XmlElement("management_url")]
        public string ManagementUrl { get; set; }
    }
}
