using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcoilopenTaskQueryResponse.
    /// </summary>
    public class AlipayOpenSpNcoilopenTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 修改文件url
        /// </summary>
        [XmlElement("fail_file_url")]
        public string FailFileUrl { get; set; }

        /// <summary>
        /// 物料提交失败数量
        /// </summary>
        [XmlElement("fail_number")]
        public long FailNumber { get; set; }

        /// <summary>
        /// 任务处理进度
        /// </summary>
        [XmlElement("task_progress")]
        public string TaskProgress { get; set; }
    }
}
