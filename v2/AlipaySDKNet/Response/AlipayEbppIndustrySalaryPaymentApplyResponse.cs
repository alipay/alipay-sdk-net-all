using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryPaymentApplyResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryPaymentApplyResponse : AopResponse
    {
        /// <summary>
        /// 代发商户的商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 网商支付订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// base64加密的响应加签xml
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }
    }
}
