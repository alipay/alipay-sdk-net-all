using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskApiConfig Data Structure.
    /// </summary>
    [Serializable]
    public class RiskApiConfig : AopObject
    {
        /// <summary>
        /// 类目风控信息列表，为必传字段。此字段为复杂模型，其中类目code为必传属性。
        /// </summary>
        [XmlArray("category_risks")]
        [XmlArrayItem("category_risk_info_api_config")]
        public List<CategoryRiskInfoApiConfig> CategoryRisks { get; set; }

        /// <summary>
        /// 押金类型，用于查询接口，创建和修改不用传入
        /// </summary>
        [XmlElement("deposit_type")]
        public string DepositType { get; set; }

        /// <summary>
        /// 多评估方案的唯一id，创建时不用传入，修改时可传入，传入时为修改此评估方案
        /// </summary>
        [XmlElement("evaluation_id")]
        public string EvaluationId { get; set; }

        /// <summary>
        /// 全局分段限额配置
        /// </summary>
        [XmlElement("quota_gradient_rule")]
        public QuotaGradientRuleApiConfig QuotaGradientRule { get; set; }
    }
}
