using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessRelationTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessRelationTradeInfo : AopObject
    {
        /// <summary>
        /// 每笔交易金额范围
        /// </summary>
        [XmlElement("avg_trade_amount")]
        public string AvgTradeAmount { get; set; }

        /// <summary>
        /// 总交易额范围
        /// </summary>
        [XmlElement("total_trade_amount")]
        public string TotalTradeAmount { get; set; }

        /// <summary>
        /// 交易笔数范围
        /// </summary>
        [XmlElement("trade_count")]
        public string TradeCount { get; set; }

        /// <summary>
        /// 客户交易人数范围
        /// </summary>
        [XmlElement("user_count")]
        public string UserCount { get; set; }

        /// <summary>
        /// 客单价范围
        /// </summary>
        [XmlElement("user_trade_amount")]
        public string UserTradeAmount { get; set; }
    }
}
