using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloanlendLenddetailQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloanlendLenddetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 放款资方，贷款实际出资机构
        /// </summary>
        [XmlElement("fund_supplier")]
        public SideloanInstitution FundSupplier { get; set; }

        /// <summary>
        /// 分期详情列表
        /// </summary>
        [XmlArray("installment_list")]
        [XmlArrayItem("lend_installment")]
        public List<LendInstallment> InstallmentList { get; set; }

        /// <summary>
        /// 机构支用借据号
        /// </summary>
        [XmlElement("institution_loan_no")]
        public string InstitutionLoanNo { get; set; }

        /// <summary>
        /// 实际执行年化利率，小数点保留6位
        /// </summary>
        [XmlElement("interest_rate")]
        public string InterestRate { get; set; }

        /// <summary>
        /// 支用放款金额，单位元
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 客户收放款的卡
        /// </summary>
        [XmlElement("loan_bank_card")]
        public GrantBankCard LoanBankCard { get; set; }

        /// <summary>
        /// 到期日 日期格式是：yyyy-mm-dd hh:mi:ss
        /// </summary>
        [XmlElement("loan_end_date")]
        public string LoanEndDate { get; set; }

        /// <summary>
        /// 支用日(放款日) 日期格式是：yyyy-mm-dd hh:mi:ss
        /// </summary>
        [XmlElement("loan_start_date")]
        public string LoanStartDate { get; set; }

        /// <summary>
        /// 贷款期限 6/11/12
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 贷款期限单位 MONTH -- "月" DAY -- "日" TERM -- “期”
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 每期固定还款日，1到28
        /// </summary>
        [XmlElement("repayment_day")]
        public long RepaymentDay { get; set; }

        /// <summary>
        /// 还款方式，枚举值 AVERAGE_CAPITAL_PLUS_INTEREST等额本息 AVERAGE_CAPITAL等额本金 BALLOON_MORTGAGE按期付息到期还本 REPAY_OUTRIGHT一次性到期还本付息
        /// </summary>
        [XmlElement("repayment_method")]
        public string RepaymentMethod { get; set; }

        /// <summary>
        /// 表示请求处理状态。可选值： SUCCESS - 成功 NEED_RETRY - 需要重试 FAIL - 不可重试
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// returnCode为FAIL或者NEED_RETRY状态下，返回具体错误码
        /// </summary>
        [XmlElement("return_sub_code")]
        public string ReturnSubCode { get; set; }

        /// <summary>
        /// 可以详细描述失败原因，方便双方定位问题
        /// </summary>
        [XmlElement("return_sub_message")]
        public string ReturnSubMessage { get; set; }

        /// <summary>
        /// 借据状态： NEW 正常 OVERDUE 预期 SETTLED 结清
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
