using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankBanktradeinfoQueryResponse.
    /// </summary>
    public class AlipayUserDtbankBanktradeinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡类型 CREDIT：信用卡，DEBIT：借记卡
        /// </summary>
        [XmlElement("bank_card_type")]
        public string BankCardType { get; set; }

        /// <summary>
        /// 银行机构id ICBC：工行， ABC：农行， BOC：中行, CEB：广大银行
        /// </summary>
        [XmlElement("bank_inst_id")]
        public string BankInstId { get; set; }
    }
}
