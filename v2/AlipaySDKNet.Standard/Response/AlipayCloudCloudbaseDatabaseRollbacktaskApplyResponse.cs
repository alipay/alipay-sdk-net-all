using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseRollbacktaskApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseDatabaseRollbacktaskApplyResponse : AopResponse
    {
        /// <summary>
        /// 回档任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
