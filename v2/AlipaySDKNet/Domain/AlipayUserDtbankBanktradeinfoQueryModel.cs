using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankBanktradeinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankBanktradeinfoQueryModel : AopObject
    {
        /// <summary>
        /// ICBC：工行， ABC：农行， BOC：中行， CEB：光大银行
        /// </summary>
        [XmlElement("bank_inst_id")]
        public string BankInstId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
