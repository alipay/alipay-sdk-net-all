using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAssistantMemberzptaskSubmitResponse.
    /// </summary>
    public class ZhimaCreditEpAssistantMemberzptaskSubmitResponse : AopResponse
    {
        /// <summary>
        /// 任务的跳转url
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 针对提交的任务返回的唯一任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
