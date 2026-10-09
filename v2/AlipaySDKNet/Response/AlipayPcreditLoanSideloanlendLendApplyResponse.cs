using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloanlendLendApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloanlendLendApplyResponse : AopResponse
    {
        /// <summary>
        /// loanStatus=FAILED支用失败，拒绝原因码
        /// </summary>
        [XmlElement("fail_reason_code")]
        public string FailReasonCode { get; set; }

        /// <summary>
        /// 描述拒绝的原因
        /// </summary>
        [XmlElement("fail_reason_message")]
        public string FailReasonMessage { get; set; }

        /// <summary>
        /// 待补充
        /// </summary>
        [XmlElement("institution_loan_apply_no")]
        public string InstitutionLoanApplyNo { get; set; }

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
        /// 放款时间，事件发生时间（格式yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("loan_time")]
        public string LoanTime { get; set; }

        /// <summary>
        /// 表示请求处理状态。可选值： SUCCESS - 成功 NEED_RETRY - 需要重试 FAIL - 不可重试
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// returnCode为FAIL或者NEED_RETRY状态下，返回具体错误码 注意：支用通过与否通过异步通知
        /// </summary>
        [XmlElement("return_sub_code")]
        public string ReturnSubCode { get; set; }

        /// <summary>
        /// 详细描述失败原因，方便双方定位问题
        /// </summary>
        [XmlElement("return_sub_message")]
        public string ReturnSubMessage { get; set; }
    }
}
