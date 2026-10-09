using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskPrizeSendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskPrizeSendInfo : AopObject
    {
        /// <summary>
        /// 任务对应的发奖流水详情
        /// </summary>
        [XmlArray("prize_send_list")]
        [XmlArrayItem("prize_send_info")]
        public List<PrizeSendInfo> PrizeSendList { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
