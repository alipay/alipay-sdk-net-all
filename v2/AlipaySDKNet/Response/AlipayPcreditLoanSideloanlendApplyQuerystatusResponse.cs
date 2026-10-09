using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloanlendApplyQuerystatusResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloanlendApplyQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 风险拒绝
        /// </summary>
        [XmlElement("fail_reason_code")]
        public string FailReasonCode { get; set; }

        /// <summary>
        /// 描述拒绝的原因
        /// </summary>
        [XmlElement("fail_reason_message")]
        public string FailReasonMessage { get; set; }

        /// <summary>
        /// 放款机构信息
        /// </summary>
        [XmlElement("fund_supplier")]
        public SideloanInstitution FundSupplier { get; set; }

        /// <summary>
        /// 机构支用申请单号
        /// </summary>
        [XmlElement("institution_loan_apply_no")]
        public string InstitutionLoanApplyNo { get; set; }

        /// <summary>
        /// 机构支用借据号，支用成功必填
        /// </summary>
        [XmlElement("institution_loan_no")]
        public string InstitutionLoanNo { get; set; }

        /// <summary>
        /// 贷款金额（单位：元）保留小数点后两位
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 放款银行卡信息
        /// </summary>
        [XmlElement("loan_bank_card")]
        public GrantBankCard LoanBankCard { get; set; }

        /// <summary>
        /// 支用状态 LOANED - 支用成功 FAILED - 支用失败 LOANING - 支用处理中，除了成功和失败之外的中间状态
        /// </summary>
        [XmlElement("loan_status")]
        public string LoanStatus { get; set; }

        /// <summary>
        /// 放款时间，放款成功时必填，事件发生时间（格式yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("loan_time")]
        public string LoanTime { get; set; }

        /// <summary>
        /// 表示请求处理状态。可选值： SUCCESS - 成功 NEED_RETRY - 需要重试 FAIL - 不可重试
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// returnCode为FAIL或者NEED_RETRY状态下，返回具体错误码，比如接口参数错误，下游系统异常等
        /// </summary>
        [XmlElement("return_sub_code")]
        public string ReturnSubCode { get; set; }

        /// <summary>
        /// 可以详细描述失败原因，方便双方定位问题
        /// </summary>
        [XmlElement("return_sub_message")]
        public string ReturnSubMessage { get; set; }
    }
}
