using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtAnticgovernanceRiskevaluationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtAnticgovernanceRiskevaluationQueryModel : AopObject
    {
        /// <summary>
        /// 风险咨询入参对象
        /// </summary>
        [XmlElement("risk_evaluation_query_request")]
        public RiskEvaluationQueryRequest RiskEvaluationQueryRequest { get; set; }
    }
}
