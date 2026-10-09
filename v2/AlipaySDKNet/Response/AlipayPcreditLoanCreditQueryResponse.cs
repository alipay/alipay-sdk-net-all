using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanCreditQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanCreditQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户授信额度
        /// </summary>
        [XmlElement("credit_amt")]
        public string CreditAmt { get; set; }

        /// <summary>
        /// 用户可用额度
        /// </summary>
        [XmlElement("loanable_amt")]
        public string LoanableAmt { get; set; }

        /// <summary>
        /// 授信申请拒绝码
        /// </summary>
        [XmlElement("reject_code")]
        public string RejectCode { get; set; }

        /// <summary>
        /// 授信申请拒绝说明
        /// </summary>
        [XmlElement("reject_message")]
        public string RejectMessage { get; set; }

        /// <summary>
        /// 用户还款日
        /// </summary>
        [XmlElement("repay_day")]
        public long RepayDay { get; set; }

        /// <summary>
        /// 贷款产品方案
        /// </summary>
        [XmlElement("schema")]
        public SchemaVO Schema { get; set; }

        /// <summary>
        /// 用户准入与授信状态，取值范围{PASS, REJECT, PENDING, PROCESSING}：PASS-通过; REJECT-拒绝; PENDING-待申请; PROCESSING-申请处理中;
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
