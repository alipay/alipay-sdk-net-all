using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainPoolCreditsignadmitQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainPoolCreditsignadmitQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前授信是否准入，准入时返回true会有授信额度和可贷额度
        /// </summary>
        [XmlElement("admit")]
        public string Admit { get; set; }

        /// <summary>
        /// 金额币种
        /// </summary>
        [XmlElement("amt_ccy")]
        public string AmtCcy { get; set; }

        /// <summary>
        /// 授信额度，单位: 元
        /// </summary>
        [XmlElement("credit_lmt_amt")]
        public string CreditLmtAmt { get; set; }

        /// <summary>
        /// 保理签约状态:  NOT_SIGNED: 未签约 SIGNED_NOT_VALID: 已签约待生效 SIGNED_VALID: 已签约已生效 SIGNED_INVALID: 已签约已失效
        /// </summary>
        [XmlElement("factoring_sign_status")]
        public string FactoringSignStatus { get; set; }

        /// <summary>
        /// 贷款余额，单位: 元
        /// </summary>
        [XmlElement("loan_balance_amt")]
        public string LoanBalanceAmt { get; set; }

        /// <summary>
        /// 可贷额度，单位: 元
        /// </summary>
        [XmlElement("loanable_amt")]
        public string LoanableAmt { get; set; }
    }
}
