using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleWorkItems Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleWorkItems : AopObject
    {
        /// <summary>
        /// 统计
        /// </summary>
        [XmlArray("stats")]
        [XmlArrayItem("schedule_work_stat_item")]
        public List<ScheduleWorkStatItem> Stats { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("work")]
        [XmlArrayItem("schedule_work_item")]
        public List<ScheduleWorkItem> Work { get; set; }
    }
}
