using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateTaskAcceptResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateTaskAcceptResponse : AopResponse
    {
        /// <summary>
        /// 详细的任务信息
        /// </summary>
        [XmlElement("task")]
        public CollaborateTask Task { get; set; }

        /// <summary>
        /// 任务号
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }
    }
}
