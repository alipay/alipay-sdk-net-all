using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorLenddetailQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorLenddetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 借款申请日期，格式yyyyMMdd
        /// </summary>
        [XmlElement("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 渠道侧借款单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 借款申请时间，时间戳毫秒
        /// </summary>
        [XmlElement("apply_time")]
        public long ApplyTime { get; set; }

        /// <summary>
        /// 年利率
        /// </summary>
        [XmlElement("apr")]
        public string Apr { get; set; }

        /// <summary>
        /// 收款卡发卡行code
        /// </summary>
        [XmlElement("bind_bank_code")]
        public string BindBankCode { get; set; }

        /// <summary>
        /// 收款卡发卡行名称
        /// </summary>
        [XmlElement("bind_bank_name")]
        public string BindBankName { get; set; }

        /// <summary>
        /// 收款卡号 (后四位)
        /// </summary>
        [XmlElement("bind_card_no")]
        public string BindCardNo { get; set; }

        /// <summary>
        /// 已签署的借款协议列表
        /// </summary>
        [XmlArray("contract_list")]
        [XmlArrayItem("honor_contract_d_t_o")]
        public List<HonorContractDTO> ContractList { get; set; }

        /// <summary>
        /// 借款优惠券id
        /// </summary>
        [XmlElement("coupon_no")]
        public string CouponNo { get; set; }

        /// <summary>
        /// 日利率
        /// </summary>
        [XmlElement("day_rate")]
        public string DayRate { get; set; }

        /// <summary>
        /// 借款起息日，格式yyyyMMdd
        /// </summary>
        [XmlElement("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 机构名称(简称)，用于给用户展示放款机构，不能脱敏
        /// </summary>
        [XmlElement("institution_names")]
        public string InstitutionNames { get; set; }

        /// <summary>
        /// 借款金额，单位：分
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 借款来源, appld（渠道侧提供）
        /// </summary>
        [XmlElement("loan_source")]
        public string LoanSource { get; set; }

        /// <summary>
        /// 随身贷支用受理单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 借据逾期未还金额，单位分，有逾期必传
        /// </summary>
        [XmlElement("overdue_amount")]
        public string OverdueAmount { get; set; }

        /// <summary>
        /// 借据逾期天数，有逾期必传
        /// </summary>
        [XmlElement("overdue_days")]
        public long OverdueDays { get; set; }

        /// <summary>
        /// 还款方式，枚举值： 1-等额本息(灵活还)， 2-等额本金(灵活还)， 3-先息后本(灵活还)， 4-等额本息(按期还)
        /// </summary>
        [XmlElement("repay_method")]
        public long RepayMethod { get; set; }

        /// <summary>
        /// 待还款计划列表（已经结清不查询）
        /// </summary>
        [XmlArray("repay_plan_terms")]
        [XmlArrayItem("honor_repay_plan_term_d_t_o")]
        public List<HonorRepayPlanTermDTO> RepayPlanTerms { get; set; }

        /// <summary>
        /// 借据状态，枚举值： 1-申请中， 2-正常还款中， 3-已逾期， 4-已结清， 5-借款失败
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 借款期数
        /// </summary>
        [XmlElement("total_term")]
        public long TotalTerm { get; set; }
    }
}
