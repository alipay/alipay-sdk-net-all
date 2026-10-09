using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EbikeChargeQrCodeResult Data Structure.
    /// </summary>
    [Serializable]
    public class EbikeChargeQrCodeResult : AopObject
    {
        /// <summary>
        /// 业务流水号，入参原样返回
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 生成二维码图片的码值
        /// </summary>
        [XmlElement("link_code")]
        public string LinkCode { get; set; }

        /// <summary>
        /// 生成的码值，拼接了入参中的自定义参数
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 方形二维码图片链接地址
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
