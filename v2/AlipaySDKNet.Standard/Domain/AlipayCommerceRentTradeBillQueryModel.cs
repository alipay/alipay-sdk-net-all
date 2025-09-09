using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentTradeBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentTradeBillQueryModel : AopObject
    {
        /// <summary>
        /// 该笔交易的还款方（租赁商）pid
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
