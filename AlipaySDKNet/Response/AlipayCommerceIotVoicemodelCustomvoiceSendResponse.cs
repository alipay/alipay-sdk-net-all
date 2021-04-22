using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotVoicemodelCustomvoiceSendResponse.
    /// </summary>
    public class AlipayCommerceIotVoicemodelCustomvoiceSendResponse : AopResponse
    {
        /// <summary>
        /// 调用的任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
