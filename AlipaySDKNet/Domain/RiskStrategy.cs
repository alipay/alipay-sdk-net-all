using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class RiskStrategy : AopObject
    {
        /// <summary>
        /// 是否有详情
        /// </summary>
        [XmlElement("has_detail")]
        public bool HasDetail { get; set; }

        /// <summary>
        /// 策略命中标识
        /// </summary>
        [XmlElement("strategy_hit_flag")]
        public bool StrategyHitFlag { get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [XmlElement("strategy_id")]
        public string StrategyId { get; set; }

        /// <summary>
        /// 风险策略名称
        /// </summary>
        [XmlElement("strategy_name")]
        public string StrategyName { get; set; }

        /// <summary>
        /// 命中策略的值
        /// </summary>
        [XmlElement("strategy_value")]
        public string StrategyValue { get; set; }

        /// <summary>
        /// 策略值状态，SUCCESS表示可用，FAILURE表示无效
        /// </summary>
        [XmlElement("strategy_value_status")]
        public string StrategyValueStatus { get; set; }

        /// <summary>
        /// 策略值类型
        /// </summary>
        [XmlElement("strategy_value_type")]
        public string StrategyValueType { get; set; }
    }
}
