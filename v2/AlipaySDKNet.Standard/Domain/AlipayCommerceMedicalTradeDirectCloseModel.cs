using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalTradeDirectCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalTradeDirectCloseModel : AopObject
    {
        /// <summary>
        /// 创单接口传入的外部订单号，trade_no和out_trade_no至少有一个要非空，优先会取trade_no
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 创单接口返回的逸康交易单号，trade_no和out_trade_no至少有一个要非空，优先会取trade_no
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
