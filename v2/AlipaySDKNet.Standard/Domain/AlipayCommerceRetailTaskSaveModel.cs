using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailTaskSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailTaskSaveModel : AopObject
    {
        /// <summary>
        /// 活动基础信息
        /// </summary>
        [XmlElement("base_info")]
        public string BaseInfo { get; set; }

        /// <summary>
        /// 权益
        /// </summary>
        [XmlElement("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 奖励规则
        /// </summary>
        [XmlElement("bonus_rule")]
        public string BonusRule { get; set; }

        /// <summary>
        /// 完成规则
        /// </summary>
        [XmlElement("completed_rule")]
        public string CompletedRule { get; set; }

        /// <summary>
        /// 投放规则
        /// </summary>
        [XmlElement("delivery_rule")]
        public string DeliveryRule { get; set; }

        /// <summary>
        /// 限制规则
        /// </summary>
        [XmlElement("limit_rule")]
        public string LimitRule { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 展示规则
        /// </summary>
        [XmlElement("show_rule")]
        public string ShowRule { get; set; }

        /// <summary>
        /// 任务行动类型
        /// </summary>
        [XmlElement("task_action")]
        public string TaskAction { get; set; }
    }
}
