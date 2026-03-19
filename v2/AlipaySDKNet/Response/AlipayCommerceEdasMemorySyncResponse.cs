using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEdasMemorySyncResponse.
    /// </summary>
    public class AlipayCommerceEdasMemorySyncResponse : AopResponse
    {
        /// <summary>
        /// 任务ID,来自请求参数
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
