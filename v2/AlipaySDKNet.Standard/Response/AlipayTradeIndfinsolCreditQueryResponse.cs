using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeIndfinsolCreditQueryResponse.
    /// </summary>
    public class AlipayTradeIndfinsolCreditQueryResponse : AopResponse
    {
        /// <summary>
        /// 银行卡账户
        /// </summary>
        [XmlElement("bank_card_number")]
        public string BankCardNumber { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
