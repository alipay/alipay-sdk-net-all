using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateTaskCompleteResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateTaskCompleteResponse : AopResponse
    {
        /// <summary>
        /// 任务号
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }
    }
}
