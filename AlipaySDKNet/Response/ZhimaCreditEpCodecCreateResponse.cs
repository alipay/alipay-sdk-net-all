using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCodecCreateResponse.
    /// </summary>
    public class ZhimaCreditEpCodecCreateResponse : AopResponse
    {
        /// <summary>
        /// 二维码地址
        /// </summary>
        [XmlElement("codec_img_url")]
        public string CodecImgUrl { get; set; }

        /// <summary>
        /// 二维码生码订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 二维码码值
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
