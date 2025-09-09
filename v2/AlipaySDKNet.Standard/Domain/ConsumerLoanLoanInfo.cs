using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanLoanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanLoanInfo : AopObject
    {
        /// <summary>
        /// 剩余待还本金，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("last_principal_amount")]
        public long LastPrincipalAmount { get; set; }

        /// <summary>
        /// 剩余待还本金，单位为分，1000代表10.00元
        /// </summary>
        [XmlElement("last_total_principal_amount")]
        public long LastTotalPrincipalAmount { get; set; }

        /// <summary>
        /// 借据信息列表
        /// </summary>
        [XmlArray("loan_info")]
        [XmlArrayItem("consumer_loan_loan_info_item")]
        public List<ConsumerLoanLoanInfoItem> LoanInfo { get; set; }

        /// <summary>
        /// 总贷款笔数，单位：笔
        /// </summary>
        [XmlElement("total_loan_count")]
        public long TotalLoanCount { get; set; }
    }
}
