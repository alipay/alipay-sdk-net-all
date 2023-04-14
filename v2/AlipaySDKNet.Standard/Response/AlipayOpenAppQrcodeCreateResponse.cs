using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppQrcodeCreateResponse.
    /// </summary>
    public class AlipayOpenAppQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 方形二维码图片链接地址
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 圆形二维码地址，蓝色slogan
        /// </summary>
        [XmlElement("qr_code_url_circle_blue")]
        public string QrCodeUrlCircleBlue { get; set; }

        /// <summary>
        /// 圆形二维码地址，白色slogan
        /// </summary>
        [XmlElement("qr_code_url_circle_white")]
        public string QrCodeUrlCircleWhite { get; set; }
    }
}
