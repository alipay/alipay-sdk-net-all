using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditCreditriskConsultQueryResponse.
    /// </summary>
    public class MybankCreditCreditriskConsultQueryResponse : AopResponse
    {
        /// <summary>
        /// 可贷额度，单位元
        /// </summary>
        [XmlElement("available_amt")]
        public string AvailableAmt { get; set; }

        /// <summary>
        /// 咨询结果，根据具体的场景约定不同的值。  授信前准入场景，返回1表示准入，0表示不准入
        /// </summary>
        [XmlElement("consult_result_code")]
        public string ConsultResultCode { get; set; }

        /// <summary>
        /// 咨询结果的描述信息。reason_code_list：不准入原因,can_manual_review:是否人工审核
        /// </summary>
        [XmlElement("consult_result_msg")]
        public string ConsultResultMsg { get; set; }

        /// <summary>
        /// 授信额度，单位元
        /// </summary>
        [XmlElement("creditlmt_amt")]
        public string CreditlmtAmt { get; set; }

        /// <summary>
        /// 贷款年化利率
        /// </summary>
        [XmlElement("loan_int_rate")]
        public string LoanIntRate { get; set; }
    }
}
