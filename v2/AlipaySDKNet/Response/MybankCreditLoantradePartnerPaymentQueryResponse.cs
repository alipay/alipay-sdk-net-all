using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradePartnerPaymentQueryResponse.
    /// </summary>
    public class MybankCreditLoantradePartnerPaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 网商内部申请单编号
        /// </summary>
        [XmlElement("in_apply_no")]
        public string InApplyNo { get; set; }

        /// <summary>
        /// 申请结果
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
