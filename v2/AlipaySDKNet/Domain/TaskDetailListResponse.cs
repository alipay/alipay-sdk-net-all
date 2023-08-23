using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskDetailListResponse Data Structure.
    /// </summary>
    [Serializable]
    public class TaskDetailListResponse : AopObject
    {
        /// <summary>
        /// 任务列表
        /// </summary>
        [XmlArray("task_detail_list_response")]
        [XmlArrayItem("task_detail_response")]
        public List<TaskDetailResponse> TaskDetailListResponse_ { get; set; }
    }
}
