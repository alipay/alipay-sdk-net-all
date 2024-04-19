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
        /// 数据文件任务提交后，为任务文件分配的编号
        /// </summary>
        [XmlElement("task_file_no")]
        public string TaskFileNo { get; set; }

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
