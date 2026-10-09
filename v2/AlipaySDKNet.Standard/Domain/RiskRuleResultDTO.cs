using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskRuleResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskRuleResultDTO : AopObject
    {
        /// <summary>
        /// 参数名：风险评估的业务详细信息 是否唯一：不唯一 应用场景：业务返回风险为包含复杂结果 枚举值：无 如何获取：不相关 特务说明：无
        /// </summary>
        [XmlElement("risk_evaluation_detail")]
        public string RiskEvaluationDetail { get; set; }

        /// <summary>
        /// 参数名：风险事项详情 是否唯一：不唯一 应用场景：描述风险规则对应的风险事项详情 枚举值：[{"value": "ANT_TREE","name": "规则来源于蚁树"},{"value": "UCRISKCORE","name": "规则来源于天燕"}] 如何获取：不相关 特务说明：无
        /// </summary>
        [XmlElement("risk_event")]
        public string RiskEvent { get; set; }

        /// <summary>
        /// 参数名：风险等级 是否唯一：不唯一 应用场景：风险等级用于判断风险严重程度 枚举值：无 如何获取：不相关 特务说明：无
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 参数名：风险提示 是否唯一：不唯一 应用场景：当前风险规则给到用户的风险提示 枚举值：[{"value": "ANT_TREE","name": "规则来源于蚁树"},{"value": "UCRISKCORE","name": "规则来源于天燕"}] 如何获取：不相关 特务说明：无
        /// </summary>
        [XmlElement("risk_note")]
        public string RiskNote { get; set; }

        /// <summary>
        /// 参数名：风险规则的风险分数 是否唯一：不唯一 应用场景：用于判断风险严重程度 枚举值：无 如何获取：不相关 特务说明：无
        /// </summary>
        [XmlElement("risk_score")]
        public long RiskScore { get; set; }

        /// <summary>
        /// 参数名：执行的规则的来源 是否唯一：不唯一 应用场景：标明执行风险规则的风险结果数据来源 枚举值：[{"value": "ANT_TREE","name": "规则来源于蚁树"},{"value": "UCRISKCORE","name": "规则来源于天燕"}] 如何获取：不相关 特务说明：无
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
