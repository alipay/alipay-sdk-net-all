using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskHunterReceiveResponse.
    /// </summary>
    public class AlipayCommerceYuntaskHunterReceiveResponse : AopResponse
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }
    }
}
