using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfFollowupimgCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfFollowupimgCreateResponse : AopResponse
    {
        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("qr_image_url")]
        public string QrImageUrl { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
