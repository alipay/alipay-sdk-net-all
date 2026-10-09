using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageConsultResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageConsultResponse : AopResponse
    {
        /// <summary>
        /// 币种  - CNY  - USD  - EUR
        /// </summary>
        [XmlElement("concurrency")]
        public string Concurrency { get; set; }

        /// <summary>
        /// 原价（分）
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 成交价格（分）
        /// </summary>
        [XmlElement("trade_price")]
        public string TradePrice { get; set; }
    }
}
