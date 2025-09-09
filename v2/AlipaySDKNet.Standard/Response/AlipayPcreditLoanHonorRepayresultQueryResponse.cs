using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorRepayresultQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorRepayresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 还款交易流水号。result_code=0时必填
        /// </summary>
        [XmlElement("out_repay_no")]
        public string OutRepayNo { get; set; }

        /// <summary>
        /// 还款金额，单位：分，还款成功必传
        /// </summary>
        [XmlElement("repay_amount")]
        public string RepayAmount { get; set; }

        /// <summary>
        /// 荣耀侧还款交易流水号。result_code=0时必填
        /// </summary>
        [XmlElement("repay_no")]
        public string RepayNo { get; set; }

        /// <summary>
        /// 还款失败原因，失败时必传
        /// </summary>
        [XmlElement("repay_result")]
        public string RepayResult { get; set; }

        /// <summary>
        /// 还款状态，1-还款中，2-还款成功，4-还款失败。result_code=0时必填
        /// </summary>
        [XmlElement("repay_status")]
        public long RepayStatus { get; set; }

        /// <summary>
        /// 还款期次明细列表
        /// </summary>
        [XmlArray("repay_terms")]
        [XmlArrayItem("honor_repay_apply_term_d_t_o")]
        public List<HonorRepayApplyTermDTO> RepayTerms { get; set; }

        /// <summary>
        /// 实际还款时间，毫秒，还款成功必传
        /// </summary>
        [XmlElement("repay_time")]
        public long RepayTime { get; set; }
    }
}
