using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayNowpaydirectPurchaseCreateResponse.
    /// </summary>
    public class AlipayAipayNowpaydirectPurchaseCreateResponse : AopResponse
    {
        /// <summary>
        /// 链接失效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 购买二维码，用于pc端直接展示二维码后扫码购买
        /// </summary>
        [XmlElement("purchase_qr_code")]
        public string PurchaseQrCode { get; set; }

        /// <summary>
        /// 购买链接地址，用于手机端直接跳转购买
        /// </summary>
        [XmlElement("purchase_url")]
        public string PurchaseUrl { get; set; }
    }
}
