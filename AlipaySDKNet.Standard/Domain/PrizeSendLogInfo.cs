using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeSendLogInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeSendLogInfo : AopObject
    {
        /// <summary>
        /// 任务对应的发奖流水详情
        /// </summary>
        [XmlArray("prize_send_log_detail_list")]
        [XmlArrayItem("prize_send_log_detail_info")]
        public List<PrizeSendLogDetailInfo> PrizeSendLogDetailList { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
