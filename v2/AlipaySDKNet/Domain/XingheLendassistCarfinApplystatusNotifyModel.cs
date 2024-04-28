using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinApplystatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinApplystatusNotifyModel : AopObject
    {
        /// <summary>
        /// 星河侧唯一业务编号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 授信金额，单位分
        /// </summary>
        [XmlElement("credit_amt")]
        public long CreditAmt { get; set; }

        /// <summary>
        /// 资方支用号
        /// </summary>
        [XmlElement("fin_drawdown_no")]
        public string FinDrawdownNo { get; set; }

        /// <summary>
        /// 资方机构名称
        /// </summary>
        [XmlElement("fin_org")]
        public string FinOrg { get; set; }

        /// <summary>
        /// 放款金额，单位分
        /// </summary>
        [XmlElement("loan_amt")]
        public long LoanAmt { get; set; }

        /// <summary>
        /// 客户放款成功日期，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("loan_date")]
        public string LoanDate { get; set; }

        /// <summary>
        /// 放款利率
        /// </summary>
        [XmlElement("loan_rate")]
        public string LoanRate { get; set; }

        /// <summary>
        /// 贷款期次
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 客户贷款期次类型，Y、M、D分别代表年月日
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 抵押率，授信金额/车辆估值金额
        /// </summary>
        [XmlElement("mortgage_rate")]
        public string MortgageRate { get; set; }

        /// <summary>
        /// 机构侧支用号，放款时必传
        /// </summary>
        [XmlElement("org_drawdown_no")]
        public string OrgDrawdownNo { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 拒绝原因错误码
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 还款方式，1：等额本金，2：等额本息，3：先息后本，4：一次性结清本息
        /// </summary>
        [XmlElement("repay_type")]
        public string RepayType { get; set; }

        /// <summary>
        /// FOLLOWING：客服跟进中，WILLING：客户有意愿，NO_WILLING：客户无意愿，PRE_REJECT：预审拒绝，PRE_PASS：预审通过，APPROVING：审批中，APPROVE_REJECT：审批拒绝，APPROVE_PASS：审批通过，SIGNING：签约中，SIGN_FAIL：签约失败，SIGNED：合同已生效，LENDING：放款中，LEND_REJECT：放款拒绝，LEND_SUC：已放款
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 车辆估值金额，单位分
        /// </summary>
        [XmlElement("valuate_price")]
        public long ValuatePrice { get; set; }
    }
}
