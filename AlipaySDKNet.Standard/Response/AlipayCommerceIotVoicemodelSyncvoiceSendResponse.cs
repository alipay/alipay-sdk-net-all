using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotVoicemodelSyncvoiceSendResponse.
    /// </summary>
    public class AlipayCommerceIotVoicemodelSyncvoiceSendResponse : AopResponse
    {
        /// <summary>
        /// 调用的任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
