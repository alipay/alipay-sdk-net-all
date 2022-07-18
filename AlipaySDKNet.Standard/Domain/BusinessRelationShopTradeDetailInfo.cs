using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessRelationShopTradeDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessRelationShopTradeDetailInfo : AopObject
    {
        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }
    }
}
