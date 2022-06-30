using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskInstanceBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskInstanceBasicInfo : AopObject
    {
        /// <summary>
        /// 任务图标
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 标的物完成数
        /// </summary>
        [XmlElement("marker_amount")]
        public long MarkerAmount { get; set; }

        /// <summary>
        /// 已经发放积分数量
        /// </summary>
        [XmlElement("published_point_amount")]
        public long PublishedPointAmount { get; set; }

        /// <summary>
        /// 任务实例状态 UNRECEIVED 未领取， 前端展示领取任务按钮 RECEIVED 已领取， 展示排名信息 FINISHED  任务完成 EXPIRED  任务到期
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

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
        /// 任务总积分数(单个导购员最大激励金额)
        /// </summary>
        [XmlElement("total_point_amount")]
        public long TotalPointAmount { get; set; }
    }
}
