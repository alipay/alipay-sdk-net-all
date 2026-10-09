using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LiveSubTaskList Data Structure.
    /// </summary>
    [Serializable]
    public class LiveSubTaskList : AopObject
    {
        /// <summary>
        /// 子任务状态，状态: COMPLETED（已完成）、UNCOMPLETED（未完成）、IN_PROGRESS（进行中）
        /// </summary>
        [XmlElement("sub_task_status")]
        public string SubTaskStatus { get; set; }

        /// <summary>
        /// VALID_LIVE_QUANTITY（30分钟及以上的挂品直播），REAL_RECEIPT_GMV（月度直播带货结算GMV）
        /// </summary>
        [XmlElement("sub_task_type")]
        public string SubTaskType { get; set; }
    }
}
