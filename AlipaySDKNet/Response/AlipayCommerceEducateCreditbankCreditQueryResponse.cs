using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankCreditQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankCreditQueryResponse : AopResponse
    {
        /// <summary>
        /// 学分信息
        /// </summary>
        [XmlArray("credit")]
        [XmlArrayItem("credit_bank_credit")]
        public List<CreditBankCredit> Credit { get; set; }
    }
}
