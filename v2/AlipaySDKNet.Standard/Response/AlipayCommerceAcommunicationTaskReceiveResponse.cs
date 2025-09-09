using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationTaskReceiveResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationTaskReceiveResponse : AopResponse
    {
        /// <summary>
        /// 真实发放积分,单位为个
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
