using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoAwardQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoAwardQueryResponse : AopResponse
    {
        /// <summary>
        /// 激励金额，单位：分
        /// </summary>
        [XmlElement("award_amount")]
        public long AwardAmount { get; set; }

        /// <summary>
        /// 报名记录id
        /// </summary>
        [XmlElement("sign_up_id")]
        public string SignUpId { get; set; }

        /// <summary>
        /// 交易笔数
        /// </summary>
        [XmlElement("trade_count")]
        public long TradeCount { get; set; }
    }
}
