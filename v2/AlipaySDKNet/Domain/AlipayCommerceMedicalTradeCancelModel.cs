using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalTradeCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalTradeCancelModel : AopObject
    {
        /// <summary>
        /// 支付时传入的商户交易号，和trade_no不能同时为空，如果都传则以trade_no优先
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 逸康交易号和out_trade_no不能同时为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
