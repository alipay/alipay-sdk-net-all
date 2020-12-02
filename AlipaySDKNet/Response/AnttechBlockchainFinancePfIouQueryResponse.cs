using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinancePfIouQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinancePfIouQueryResponse : AopResponse
    {
        /// <summary>
        /// 借据Id
        /// </summary>
        [XmlElement("credit_id")]
        public string CreditId { get; set; }

        /// <summary>
        /// 发放金额
        /// </summary>
        [XmlElement("issued_amount")]
        public string IssuedAmount { get; set; }

        /// <summary>
        /// 贷款入账账号
        /// </summary>
        [XmlElement("pay_in_account")]
        public string PayInAccount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 还款账号
        /// </summary>
        [XmlElement("repay_account")]
        public string RepayAccount { get; set; }
    }
}
