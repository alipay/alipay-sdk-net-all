using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcCreditLoanQueryResponse.
    /// </summary>
    public class AlipayCommerceEcCreditLoanQueryResponse : AopResponse
    {
        /// <summary>
        /// 借款申请记录
        /// </summary>
        [XmlArray("loan_apply_infos")]
        [XmlArrayItem("loan_apply")]
        public List<LoanApply> LoanApplyInfos { get; set; }
    }
}
