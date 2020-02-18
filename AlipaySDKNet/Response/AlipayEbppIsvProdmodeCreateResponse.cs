using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIsvProdmodeCreateResponse.
    /// </summary>
    public class AlipayEbppIsvProdmodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 流程实例ID
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 创建产品模型成功后返回任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
