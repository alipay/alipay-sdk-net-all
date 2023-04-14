using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountExrateConfigQueryResponse.
    /// </summary>
    public class AlipayAccountExrateConfigQueryResponse : AopResponse
    {
        /// <summary>
        /// scheduler配置的自定义键值对
        /// </summary>
        [XmlElement("task_context")]
        public string TaskContext { get; set; }

        /// <summary>
        /// scheduler的状态码
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// scheduler的配置类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
