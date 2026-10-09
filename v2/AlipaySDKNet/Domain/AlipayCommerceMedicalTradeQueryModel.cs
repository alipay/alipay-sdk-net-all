using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalTradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalTradeQueryModel : AopObject
    {
        /// <summary>
        /// 外部交易流水号。与trade_no不能都为空，都有值时优先取trade_no
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 平台交易流水号。与out_trade_no不能都为空，都有值时优先取trade_no
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
