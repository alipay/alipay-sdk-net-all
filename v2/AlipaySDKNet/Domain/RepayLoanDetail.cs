using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepayLoanDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RepayLoanDetail : AopObject
    {
        /// <summary>
        /// 支用受理单号，蚂蚁侧生成
        /// </summary>
        [XmlElement("institution_loan_apply_no")]
        public string InstitutionLoanApplyNo { get; set; }

        /// <summary>
        /// 蚂蚁侧借据号
        /// </summary>
        [XmlElement("institution_loan_no")]
        public string InstitutionLoanNo { get; set; }

        /// <summary>
        /// 外部渠道支用申请单号
        /// </summary>
        [XmlElement("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 还款利息，单位：元，精度：保留两位小数；还款成功时返回。
        /// </summary>
        [XmlElement("repaid_interest")]
        public string RepaidInterest { get; set; }

        /// <summary>
        /// 还款罚息（本罚+利罚），单位：元，精度：保留两位小数；还款成功时返回。
        /// </summary>
        [XmlElement("repaid_penalty")]
        public string RepaidPenalty { get; set; }

        /// <summary>
        /// 还款本金，单位：元，精度：保留两位小数；还款成功时返回。
        /// </summary>
        [XmlElement("repaid_principal")]
        public string RepaidPrincipal { get; set; }

        /// <summary>
        /// 还款成功时间，还款成功时返回（格式yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("repaid_time")]
        public string RepaidTime { get; set; }

        /// <summary>
        /// 还款总额，单位：元，精度：保留两位小数。还款成功时返回。
        /// </summary>
        [XmlElement("repaid_total_amount")]
        public string RepaidTotalAmount { get; set; }

        /// <summary>
        /// 还款明细单号，借据维度还款明细
        /// </summary>
        [XmlElement("repay_detail_no")]
        public string RepayDetailNo { get; set; }
    }
}
