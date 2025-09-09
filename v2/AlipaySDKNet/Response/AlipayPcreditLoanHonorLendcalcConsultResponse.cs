using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorLendcalcConsultResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorLendcalcConsultResponse : AopResponse
    {
        /// <summary>
        /// 综合年利率, 示例12.95【即12.95%】 (优惠后)
        /// </summary>
        [XmlElement("annual_rate")]
        public string AnnualRate { get; set; }

        /// <summary>
        /// 默选的银行卡信息
        /// </summary>
        [XmlElement("bank_card")]
        public HonorBankCardDTO BankCard { get; set; }

        /// <summary>
        /// 返回借款协议，默认返回
        /// </summary>
        [XmlArray("contract")]
        [XmlArrayItem("honor_contract_d_t_o")]
        public List<HonorContractDTO> Contract { get; set; }

        /// <summary>
        /// 首次还款日, 格式yyyyMMdd
        /// </summary>
        [XmlElement("first_repay_date")]
        public string FirstRepayDate { get; set; }

        /// <summary>
        /// 最后还款日, 格式yyyyMMdd
        /// </summary>
        [XmlElement("last_repay_date")]
        public string LastRepayDate { get; set; }

        /// <summary>
        /// 优惠前原价年利率, 示例12.95【即12.95%】
        /// </summary>
        [XmlElement("original_rate")]
        public string OriginalRate { get; set; }

        /// <summary>
        /// 拒绝原因码, status=1时必传
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因说明, status=1时必传
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 拒绝具体原因说明， status=1时必传
        /// </summary>
        [XmlElement("refuse_msg_data")]
        public string RefuseMsgData { get; set; }

        /// <summary>
        /// 还款计划
        /// </summary>
        [XmlArray("repay_plan_terms")]
        [XmlArrayItem("honor_repay_plan_term_d_t_o")]
        public List<HonorRepayPlanTermDTO> RepayPlanTerms { get; set; }

        /// <summary>
        /// 应还总额，单位：分(应还总额=应还本金总额+应还利息总额)
        /// </summary>
        [XmlElement("should_repay_amount")]
        public string ShouldRepayAmount { get; set; }

        /// <summary>
        /// 应还利息总额，单位：分
        /// </summary>
        [XmlElement("should_repay_inter_amount")]
        public string ShouldRepayInterAmount { get; set; }

        /// <summary>
        /// 应还本金总额，单位：分
        /// </summary>
        [XmlElement("should_repay_prin_amount")]
        public string ShouldRepayPrinAmount { get; set; }

        /// <summary>
        /// 出资方
        /// </summary>
        [XmlElement("stakeholders")]
        public string Stakeholders { get; set; }

        /// <summary>
        /// 状态， 1、拒绝  2、通过
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 总优惠金额，单位：分
        /// </summary>
        [XmlElement("total_discount")]
        public string TotalDiscount { get; set; }

        /// <summary>
        /// 借款试算咨询id
        /// </summary>
        [XmlElement("trial_serial_no")]
        public string TrialSerialNo { get; set; }
    }
}
