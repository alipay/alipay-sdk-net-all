using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskInstanceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskInstanceInfo : AopObject
    {
        /// <summary>
        /// 当前进度
        /// </summary>
        [XmlElement("current_indicator")]
        public long CurrentIndicator { get; set; }

        /// <summary>
        /// 激励方式
        /// </summary>
        [XmlElement("incentive_mode")]
        public string IncentiveMode { get; set; }

        /// <summary>
        /// 激励规则
        /// </summary>
        [XmlElement("incentive_rule")]
        public string IncentiveRule { get; set; }

        /// <summary>
        /// 任务标的物推广数
        /// </summary>
        [XmlElement("marker_promoted_count")]
        public long MarkerPromotedCount { get; set; }

        /// <summary>
        /// 任务最大激励笔数
        /// </summary>
        [XmlElement("max_incentive_count")]
        public long MaxIncentiveCount { get; set; }

        /// <summary>
        /// 任务获取总积分数
        /// </summary>
        [XmlElement("published_point_amount")]
        public long PublishedPointAmount { get; set; }

        /// <summary>
        /// 任务实例状态 UNRECEIVED 未领取 RECEIVED 已领取 FINISHED  任务完成
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 目标进度
        /// </summary>
        [XmlElement("target_indicator")]
        public long TargetIndicator { get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [XmlElement("task_end_time")]
        public string TaskEndTime { get; set; }

        /// <summary>
        /// 任务实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// 任务logo
        /// </summary>
        [XmlElement("task_logo")]
        public string TaskLogo { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [XmlElement("task_start_time")]
        public string TaskStartTime { get; set; }

        /// <summary>
        /// 任务模板id
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 任务最多可获取积分数
        /// </summary>
        [XmlElement("total_point_amount")]
        public long TotalPointAmount { get; set; }

        /// <summary>
        /// 未兑换积分数
        /// </summary>
        [XmlElement("unexchange_point_amount")]
        public long UnexchangePointAmount { get; set; }
    }
}
