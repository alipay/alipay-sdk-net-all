using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleOrderRoyaltyInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleOrderRoyaltyInfoVO : AopObject
    {
        /// <summary>
        /// 交易金额，单位元
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易对象
        /// </summary>
        [XmlElement("trade_in")]
        public string TradeIn { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 交易完成时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
