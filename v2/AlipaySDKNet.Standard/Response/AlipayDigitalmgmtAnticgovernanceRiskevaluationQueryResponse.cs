using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtAnticgovernanceRiskevaluationQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtAnticgovernanceRiskevaluationQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务风险结果
        /// </summary>
        [XmlElement("risk_evaluation_result")]
        public RiskEvaluationResult RiskEvaluationResult { get; set; }
    }
}
