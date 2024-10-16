using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateTaskPullResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateTaskPullResponse : AopResponse
    {
        /// <summary>
        /// 拉取到的任务数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 分配给当前isv的协同任务明细。
        /// </summary>
        [XmlArray("tasks")]
        [XmlArrayItem("collaborate_task")]
        public List<CollaborateTask> Tasks { get; set; }
    }
}
