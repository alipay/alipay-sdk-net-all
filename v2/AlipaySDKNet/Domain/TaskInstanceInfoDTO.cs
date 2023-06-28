using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskInstanceInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TaskInstanceInfoDTO : AopObject
    {
        /// <summary>
        /// 任务完成时间
        /// </summary>
        [XmlElement("complete_time")]
        public string CompleteTime { get; set; }

        /// <summary>
        /// 当前进度
        /// </summary>
        [XmlElement("current_num")]
        public long CurrentNum { get; set; }

        /// <summary>
        /// 任务最大激励笔数
        /// </summary>
        [XmlElement("max_incentive_count")]
        public long MaxIncentiveCount { get; set; }

        /// <summary>
        /// 已发放金额，元
        /// </summary>
        [XmlElement("published_amount")]
        public string PublishedAmount { get; set; }

        /// <summary>
        /// 任务领取时间
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 任务激励类型
        /// </summary>
        [XmlElement("reward_type")]
        public string RewardType { get; set; }

        /// <summary>
        /// 任务实例状态 UNRECEIVED 未领取 RECEIVED 已领取 FINISHED  任务完成
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 激励任务目标数量
        /// </summary>
        [XmlElement("target_num")]
        public long TargetNum { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 最大激励金额，单位元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
