using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcCreditBillrepayQueryResponse.
    /// </summary>
    public class AlipayCommerceEcCreditBillrepayQueryResponse : AopResponse
    {
        /// <summary>
        /// 授信账单还款信息
        /// </summary>
        [XmlArray("repayments")]
        [XmlArrayItem("ec_credit_bill_repayment")]
        public List<EcCreditBillRepayment> Repayments { get; set; }
    }
}
