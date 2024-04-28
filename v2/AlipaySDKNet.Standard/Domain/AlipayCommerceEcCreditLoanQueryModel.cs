using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditLoanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditLoanQueryModel : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 时间范围查询的结束时间，格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 借款申请状态
        /// </summary>
        [XmlElement("loan_status")]
        public string LoanStatus { get; set; }

        /// <summary>
        /// 时间范围查询的开始时间，格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
