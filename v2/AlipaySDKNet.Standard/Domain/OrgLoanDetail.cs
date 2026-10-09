using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrgLoanDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OrgLoanDetail : AopObject
    {
        /// <summary>
        /// 客户授信金额（审批金额），单位分
        /// </summary>
        [XmlElement("credit_amt")]
        public long CreditAmt { get; set; }

        /// <summary>
        /// 是否为主产品：Y/N
        /// </summary>
        [XmlElement("is_main_product")]
        public string IsMainProduct { get; set; }

        /// <summary>
        /// 客户放款金额，单位分
        /// </summary>
        [XmlElement("loan_amt")]
        public long LoanAmt { get; set; }

        /// <summary>
        /// 客户放款成功日期，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("loan_date")]
        public string LoanDate { get; set; }

        /// <summary>
        /// 客户贷款利率，类型为小数，代表百分比，比如 0.18 就是18%
        /// </summary>
        [XmlElement("loan_rate")]
        public string LoanRate { get; set; }

        /// <summary>
        /// 客户贷款期次，类型为数字，单位支持Y、M等，单位字段从loan_term_unit获取
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 客户贷款期次类型 Y、M分别代表年月，当前支持M
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 机构侧支用号
        /// </summary>
        [XmlElement("org_drawdown_no")]
        public string OrgDrawdownNo { get; set; }

        /// <summary>
        /// 还款方式 1：等额本金；2：等额本息；3：先息后本；4：一次性结清本息
        /// </summary>
        [XmlElement("repay_type")]
        public string RepayType { get; set; }
    }
}
