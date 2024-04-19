using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDeductionorderPayResponse.
    /// </summary>
    public class AlipayCommerceDeductionorderPayResponse : AopResponse
    {
        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
