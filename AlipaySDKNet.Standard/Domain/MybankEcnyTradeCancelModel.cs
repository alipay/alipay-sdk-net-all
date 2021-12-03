using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyTradeCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyTradeCancelModel : AopObject
    {
        /// <summary>
        /// 调用方订单号，调用方订单号和运营机构交易号不能同时为空
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 运营机构交易号，调用方订单号和运营机构交易号不能同时为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
