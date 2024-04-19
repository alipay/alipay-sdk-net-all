using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskIndustryFarmingQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskIndustryFarmingQueryResponse : AopResponse
    {
        /// <summary>
        /// risk_result:风险分析结果，类型为列表，包含风险分析结果和描述。分别是 risk_type:marketing_awarding_common; risk_value:(hasRisk,noRisk)/("rank1",...,"rank10"); risk_desc:是否有风险/风险等级; 每一次返回，根据配置的不同，可以返回同样的风险结果类型，也可以返回不同的风险结果类型。
        /// </summary>
        [XmlArray("risk_result")]
        [XmlArrayItem("riskpluscore_risk_query_result")]
        public List<RiskpluscoreRiskQueryResult> RiskResult { get; set; }
    }
}
