using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryPaymentQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryPaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// 代发商户商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 银行流水号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 响应加签xml, base64编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
