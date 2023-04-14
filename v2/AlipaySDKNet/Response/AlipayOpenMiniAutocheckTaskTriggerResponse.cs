using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAutocheckTaskTriggerResponse.
    /// </summary>
    public class AlipayOpenMiniAutocheckTaskTriggerResponse : AopResponse
    {
        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
