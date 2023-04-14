using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RpaCrawlerTaskVO Data Structure.
    /// </summary>
    [Serializable]
    public class RpaCrawlerTaskVO : AopObject
    {
        /// <summary>
        /// 算法id
        /// </summary>
        [XmlElement("algo_id")]
        public string AlgoId { get; set; }

        /// <summary>
        /// 业务目标
        /// </summary>
        [XmlElement("biz_goal")]
        public string BizGoal { get; set; }

        /// <summary>
        /// 创意列表
        /// </summary>
        [XmlArray("creative_code_list")]
        [XmlArrayItem("string")]
        public List<string> CreativeCodeList { get; set; }

        /// <summary>
        /// 创意包code
        /// </summary>
        [XmlElement("creative_group_code")]
        public string CreativeGroupCode { get; set; }

        /// <summary>
        /// 创意包版本
        /// </summary>
        [XmlElement("creative_group_version")]
        public string CreativeGroupVersion { get; set; }

        /// <summary>
        /// 人群列表
        /// </summary>
        [XmlArray("crowd_id_list")]
        [XmlArrayItem("string")]
        public List<string> CrowdIdList { get; set; }

        /// <summary>
        /// 单元名称
        /// </summary>
        [XmlElement("deliver_unit_name")]
        public string DeliverUnitName { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 疲劳度
        /// </summary>
        [XmlElement("fatigue")]
        public string Fatigue { get; set; }

        /// <summary>
        /// 计划code
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 展位码
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [XmlElement("strategy_id")]
        public string StrategyId { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 白名单列表
        /// </summary>
        [XmlArray("white_list")]
        [XmlArrayItem("string")]
        public List<string> WhiteList { get; set; }
    }
}
