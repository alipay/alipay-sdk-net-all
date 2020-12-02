using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZMGoTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZMGoTradeInfo : AopObject
    {
        /// <summary>
        /// 用户和商户发生交易的交易单金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 用户和商户发生交易的交易单号，仅在商户需要回传交易信息时传入。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
