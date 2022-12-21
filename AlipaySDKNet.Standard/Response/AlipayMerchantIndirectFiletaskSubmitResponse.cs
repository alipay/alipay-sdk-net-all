using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectFiletaskSubmitResponse.
    /// </summary>
    public class AlipayMerchantIndirectFiletaskSubmitResponse : AopResponse
    {
        /// <summary>
        /// 文件任务处理结果
        /// </summary>
        [XmlElement("task_state")]
        public string TaskState { get; set; }

        /// <summary>
        /// 文件任务状态描述
        /// </summary>
        [XmlElement("task_state_desc")]
        public string TaskStateDesc { get; set; }
    }
}
