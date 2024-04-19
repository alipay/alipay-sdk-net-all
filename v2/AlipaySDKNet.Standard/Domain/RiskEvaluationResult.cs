using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskEvaluationResult Data Structure.
    /// </summary>
    [Serializable]
    public class RiskEvaluationResult : AopObject
    {
        /// <summary>
        /// 风险实例id+唯一
        /// </summary>
        [XmlElement("risk_instance_id")]
        public string RiskInstanceId { get; set; }

        /// <summary>
        /// 风险评估的风险等级+非唯一+MEDIUM
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 评估的风险规则明细+非唯一
        /// </summary>
        [XmlArray("risk_rule_result_list")]
        [XmlArrayItem("risk_rule_result_d_t_o")]
        public List<RiskRuleResultDTO> RiskRuleResultList { get; set; }
    }
}
