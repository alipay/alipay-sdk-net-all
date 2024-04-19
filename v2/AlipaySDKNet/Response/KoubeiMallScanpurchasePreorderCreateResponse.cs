using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMallScanpurchasePreorderCreateResponse.
    /// </summary>
    public class KoubeiMallScanpurchasePreorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 预订单编号
        /// </summary>
        [XmlElement("advance_order_id")]
        public string AdvanceOrderId { get; set; }

        /// <summary>
        /// 二维码code
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 二维码链接地址
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
