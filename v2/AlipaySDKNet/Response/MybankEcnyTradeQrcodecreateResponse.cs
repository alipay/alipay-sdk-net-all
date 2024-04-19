using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyTradeQrcodecreateResponse.
    /// </summary>
    public class MybankEcnyTradeQrcodecreateResponse : AopResponse
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 生成的二维码值
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }
    }
}
