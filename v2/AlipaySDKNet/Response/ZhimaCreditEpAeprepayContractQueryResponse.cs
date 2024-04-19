using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAeprepayContractQueryResponse.
    /// </summary>
    public class ZhimaCreditEpAeprepayContractQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admitted")]
        public bool Admitted { get; set; }

        /// <summary>
        /// 授信额度=盖帽，币种最小单位-分
        /// </summary>
        [XmlElement("credit_limit_amount")]
        public long CreditLimitAmount { get; set; }

        /// <summary>
        /// 授信额度币种
        /// </summary>
        [XmlElement("credit_limit_currency")]
        public string CreditLimitCurrency { get; set; }

        /// <summary>
        /// 不准入原因
        /// </summary>
        [XmlElement("denied_reason")]
        public string DeniedReason { get; set; }

        /// <summary>
        /// 可贷金额=(盖帽-占用)， 币种最小单位-分
        /// </summary>
        [XmlElement("loanable_amount")]
        public long LoanableAmount { get; set; }

        /// <summary>
        /// 可贷金额币种
        /// </summary>
        [XmlElement("loanable_currency")]
        public string LoanableCurrency { get; set; }

        /// <summary>
        /// 是否签约
        /// </summary>
        [XmlElement("signed")]
        public bool Signed { get; set; }

        /// <summary>
        /// 是否解约
        /// </summary>
        [XmlElement("unsigned")]
        public bool Unsigned { get; set; }

        /// <summary>
        /// 解约时间
        /// </summary>
        [XmlElement("unsigned_date")]
        public string UnsignedDate { get; set; }
    }
}
