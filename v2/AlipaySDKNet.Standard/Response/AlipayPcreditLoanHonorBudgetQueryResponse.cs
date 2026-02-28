using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorBudgetQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorBudgetQueryResponse : AopResponse
    {
        /// <summary>
        /// 按期还，提前还款手续费率：4【即4%】
        /// </summary>
        [XmlElement("fee_rate")]
        public string FeeRate { get; set; }

        /// <summary>
        /// 总还款金额，单位：分。result_code=0时必填
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 还款利息金额，单位：分。result_code=0时必填
        /// </summary>
        [XmlElement("total_interest")]
        public string TotalInterest { get; set; }

        /// <summary>
        /// 总罚息，单位：分，result_code=0&有罚息时必填
        /// </summary>
        [XmlElement("total_penalty")]
        public string TotalPenalty { get; set; }

        /// <summary>
        /// 还款本金金额，单位：分。result_code=0时必填
        /// </summary>
        [XmlElement("total_principal")]
        public string TotalPrincipal { get; set; }

        /// <summary>
        /// 提前还款违约金，单位：分
        /// </summary>
        [XmlElement("total_violate_fee")]
        public string TotalViolateFee { get; set; }
    }
}
