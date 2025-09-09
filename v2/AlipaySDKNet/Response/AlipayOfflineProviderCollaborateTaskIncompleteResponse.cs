using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateTaskIncompleteResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateTaskIncompleteResponse : AopResponse
    {
        /// <summary>
        /// 任务号
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }
    }
}
