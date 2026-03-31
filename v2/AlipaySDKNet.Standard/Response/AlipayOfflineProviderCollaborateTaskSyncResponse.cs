using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateTaskSyncResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateTaskSyncResponse : AopResponse
    {
        /// <summary>
        /// 任务leadsId
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
