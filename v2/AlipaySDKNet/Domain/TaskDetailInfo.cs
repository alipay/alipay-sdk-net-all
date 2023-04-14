using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskDetailInfo : AopObject
    {
        /// <summary>
        /// 已领取积分
        /// </summary>
        [XmlElement("applied_point")]
        public long AppliedPoint { get; set; }

        /// <summary>
        /// 任务进度和可领取积分对应关系
        /// </summary>
        [XmlElement("indicator_point_map")]
        public string IndicatorPointMap { get; set; }

        /// <summary>
        /// 积分状态； unFinished：不可领积分； canFetch：积分待领取； applied：积分已领取
        /// </summary>
        [XmlElement("point_status")]
        public string PointStatus { get; set; }

        /// <summary>
        /// 任务code，唯一标识
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 任务当前进度
        /// </summary>
        [XmlElement("task_current_indicator")]
        public long TaskCurrentIndicator { get; set; }

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
        /// 赚钱攻略
        /// </summary>
        [XmlElement("task_introduction_url")]
        public string TaskIntroductionUrl { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

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
        /// 任务目标进度
        /// </summary>
        [XmlElement("task_target_indicator")]
        public long TaskTargetIndicator { get; set; }
    }
}
