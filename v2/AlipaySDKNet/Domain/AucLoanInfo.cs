using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AucLoanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AucLoanInfo : AopObject
    {
        /// <summary>
        /// 资金利率
        /// </summary>
        [XmlElement("fund_rate")]
        public string FundRate { get; set; }

        /// <summary>
        /// 客户放款金额，单位分
        /// </summary>
        [XmlElement("loan_amt")]
        public long LoanAmt { get; set; }

        /// <summary>
        /// 放款成功时间
        /// </summary>
        [XmlElement("loan_date")]
        public string LoanDate { get; set; }

        /// <summary>
        /// 客户贷款利率(部分机构称“综合利率”)
        /// </summary>
        [XmlElement("loan_rate")]
        public string LoanRate { get; set; }

        /// <summary>
        /// 客户贷款期次
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 客户贷款期次类型 Y、M、D分别代表年月日
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 机构侧支用号
        /// </summary>
        [XmlElement("org_drawdown_no")]
        public string OrgDrawdownNo { get; set; }

        /// <summary>
        /// 还款方式
        /// </summary>
        [XmlElement("repay_type")]
        public string RepayType { get; set; }

        /// <summary>
        /// 服务费率（融担费率、保险费率等） 注：如果不存在担保费率，则该字段不要传任何值（null）
        /// </summary>
        [XmlElement("service_fee_rate")]
        public string ServiceFeeRate { get; set; }
    }
}
