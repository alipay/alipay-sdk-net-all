using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvDsbGetResponse.
    /// </summary>
    public class AnttechAiCvDsbGetResponse : AopResponse
    {
        /// <summary>
        /// 定损结果的下载链接，15分钟内有效
        /// </summary>
        [XmlElement("result_url")]
        public string ResultUrl { get; set; }

        /// <summary>
        /// 总共3个状态：RUNNING，SUCC，FAILED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 请求参数内传入的task_id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
