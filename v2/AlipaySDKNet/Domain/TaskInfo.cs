using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskInfo : AopObject
    {
        /// <summary>
        /// 已获得积分数
        /// </summary>
        [XmlElement("earned_point")]
        public long EarnedPoint { get; set; }

        /// <summary>
        /// 任务归属类型 PLATFORM：平台 THIRD_PARTY：三方
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 任务code，唯一标识
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务结束时间：格式"yyyy.MM.dd"
        /// </summary>
        [XmlElement("task_end_time")]
        public string TaskEndTime { get; set; }

        /// <summary>
        /// 任务图标链接
        /// </summary>
        [XmlElement("task_icon_url")]
        public string TaskIconUrl { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务剩余积分数
        /// </summary>
        [XmlElement("task_remain_point")]
        public long TaskRemainPoint { get; set; }

        /// <summary>
        /// 任务开始时间；格式"yyyy.MM.dd"
        /// </summary>
        [XmlElement("task_start_time")]
        public string TaskStartTime { get; set; }

        /// <summary>
        /// 任务状态； UN_STARTED：未开始； INIT：未领任务； RUNNING：进行中； FINISH：已完成
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 总积分数
        /// </summary>
        [XmlElement("total_point")]
        public long TotalPoint { get; set; }
    }
}
