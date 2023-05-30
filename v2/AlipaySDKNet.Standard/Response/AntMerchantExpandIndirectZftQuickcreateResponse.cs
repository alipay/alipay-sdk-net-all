using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftQuickcreateResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftQuickcreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 签约确认二维码链接
        /// </summary>
        [XmlElement("sign_qr_code_url")]
        public string SignQrCodeUrl { get; set; }

        /// <summary>
        /// 签约确认生成的短链链接
        /// </summary>
        [XmlElement("sign_short_chain_url")]
        public string SignShortChainUrl { get; set; }
    }
}
