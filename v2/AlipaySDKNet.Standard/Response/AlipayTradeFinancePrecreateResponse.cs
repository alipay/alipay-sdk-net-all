using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeFinancePrecreateResponse.
    /// </summary>
    public class AlipayTradeFinancePrecreateResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS 成功 ACCEPT_SUCCESS 受理成功
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 支付宝快收单号
        /// </summary>
        [XmlElement("settlement_no")]
        public string SettlementNo { get; set; }
    }
}
