using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeIdentityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradeIdentityInfo : AopObject
    {
        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 收单pid/smid
        /// </summary>
        [XmlElement("trade_pid")]
        public string TradePid { get; set; }

        /// <summary>
        /// 收单shopId
        /// </summary>
        [XmlElement("trade_shopid")]
        public string TradeShopid { get; set; }
    }
}
