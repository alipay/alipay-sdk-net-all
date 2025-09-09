using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskConfigDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskConfigDTO : AopObject
    {
        /// <summary>
        /// 类目风控信息列表
        /// </summary>
        [XmlArray("category_risks")]
        [XmlArrayItem("category_risk_d_t_o")]
        public List<CategoryRiskDTO> CategoryRisks { get; set; }

        /// <summary>
        /// 全局分段限额配置
        /// </summary>
        [XmlElement("quota_gradient_rule")]
        public QuotaGradientRuleDTO QuotaGradientRule { get; set; }
    }
}
