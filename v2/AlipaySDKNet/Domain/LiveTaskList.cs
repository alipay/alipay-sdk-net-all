using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LiveTaskList Data Structure.
    /// </summary>
    [Serializable]
    public class LiveTaskList : AopObject
    {
        /// <summary>
        /// 任务日期（月份）
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 日期格式
        /// </summary>
        [XmlElement("date_formate")]
        public string DateFormate { get; set; }

        /// <summary>
        /// 子任务列表
        /// </summary>
        [XmlArray("live_sub_task_list")]
        [XmlArrayItem("live_sub_task_list")]
        public List<LiveSubTaskList> LiveSubTaskList { get; set; }

        /// <summary>
        /// 月度任务状态，状态: COMPLETED（已完成）、UNCOMPLETED（未完成）、IN_PROGRESS（进行中）
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务类型：直播（LIVE）
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
