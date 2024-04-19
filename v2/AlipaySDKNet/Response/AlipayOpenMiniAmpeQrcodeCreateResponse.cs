using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeQrcodeCreateResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成的二维码图片地址
        /// </summary>
        [XmlElement("qrcode_img_url")]
        public string QrcodeImgUrl { get; set; }
    }
}
