using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanSideloanrepayResultQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanSideloanrepayResultQueryResponse : AopResponse
    {
        /// <summary>
        /// 还款失败的金额(单位元)。精确小数点后2位。主动还款部分成功部分失败时，此值必传
        /// </summary>
        [XmlElement("charge_back_amount")]
        public string ChargeBackAmount { get; set; }

        /// <summary>
        /// 还款失败原因编码
        /// </summary>
        [XmlElement("fail_reason_code")]
        public string FailReasonCode { get; set; }

        /// <summary>
        /// 还款失败原因描述
        /// </summary>
        [XmlElement("fail_reason_message")]
        public string FailReasonMessage { get; set; }

        /// <summary>
        /// 蚂蚁还款受理单号，蚂蚁侧生成
        /// </summary>
        [XmlElement("institution_repayment_no")]
        public string InstitutionRepaymentNo { get; set; }

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
        /// 还款申请单号，外部渠道生成
        /// </summary>
        [XmlElement("repay_apply_no")]
        public string RepayApplyNo { get; set; }

        /// <summary>
        /// 还款发起方。 ALI:阿里侧发起还款 INSTITUTION:机构侧发起（批扣或客户在机构侧发起）
        /// </summary>
        [XmlElement("repay_initiator")]
        public string RepayInitiator { get; set; }

        /// <summary>
        /// 还款详情信息，借据维度还款详情列表
        /// </summary>
        [XmlArray("repay_loan_detail_list")]
        [XmlArrayItem("repay_loan_detail")]
        public List<RepayLoanDetail> RepayLoanDetailList { get; set; }

        /// <summary>
        /// 还款状态，用来描述还款状态。 SUCCESS - 还款成功 PROCESSING - 还款中 FAILED - 还款失败
        /// </summary>
        [XmlElement("repay_status")]
        public string RepayStatus { get; set; }

        /// <summary>
        /// 表示请求处理状态。  SUCCESS - 成功  NEED_RETRY -需要重试  FAIL - 不可重试
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
    }
}
