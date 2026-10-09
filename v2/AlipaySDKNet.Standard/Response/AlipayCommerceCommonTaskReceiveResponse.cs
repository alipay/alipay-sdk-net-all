using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonTaskReceiveResponse.
    /// </summary>
    public class AlipayCommerceCommonTaskReceiveResponse : AopResponse
    {
        /// <summary>
        /// 任务领取实例id
        /// </summary>
        [XmlElement("task_instance_id")]
        public string TaskInstanceId { get; set; }
    }
}
