using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeOrderOnsettleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeOrderOnsettleQueryModel : AopObject
    {
        /// <summary>
        /// unsettled表示从待结算资金分账；不传表示从售后分账
        /// </summary>
        [XmlElement("royalty_source")]
        public string RoyaltySource { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
