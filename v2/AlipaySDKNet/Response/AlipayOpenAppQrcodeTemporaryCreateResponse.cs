using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppQrcodeTemporaryCreateResponse.
    /// </summary>
    public class AlipayOpenAppQrcodeTemporaryCreateResponse : AopResponse
    {
        /// <summary>
        /// 动态二维码的支付宝码值
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 动态二维码图片URL
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
