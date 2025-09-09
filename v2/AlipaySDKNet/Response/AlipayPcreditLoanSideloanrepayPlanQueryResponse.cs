using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloanrepayPlanQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloanrepayPlanQueryResponse : AopResponse
    {
        /// <summary>
        /// 所有到期分期汇总合并信息
        /// </summary>
        [XmlElement("due_merged_installment_bill")]
        public MergedInstallmentBill DueMergedInstallmentBill { get; set; }

        /// <summary>
        /// 最近一期分期账单合并
        /// </summary>
        [XmlElement("following_merged_installment_bill")]
        public MergedInstallmentBill FollowingMergedInstallmentBill { get; set; }

        /// <summary>
        /// 分期账单列表
        /// </summary>
        [XmlArray("installment_bill_list")]
        [XmlArrayItem("installment_bill")]
        public List<InstallmentBill> InstallmentBillList { get; set; }

        /// <summary>
        /// 所有逾期分期汇总
        /// </summary>
        [XmlElement("overdue_merged_installment_bill")]
        public MergedInstallmentBill OverdueMergedInstallmentBill { get; set; }

        /// <summary>
        /// 表示请求处理状态。 SUCCESS - 成功 NEED_RETRY -需要重试 FAIL - 不可重试
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
        /// 未结清借据总数
        /// </summary>
        [XmlElement("unpaid_loan_total")]
        public long UnpaidLoanTotal { get; set; }
    }
}
