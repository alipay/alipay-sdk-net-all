using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDirectTradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDirectTradeQueryModel : AopObject
    {
        /// <summary>
        /// trade_no和out_trade_no至少有一个要非空，优先会取trade_no
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// trade_no和out_trade_no至少有一个要非空，优先会取trade_no
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
