using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvDsbIdentifyResponse.
    /// </summary>
    public class AnttechAiCvDsbIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 本次inference任务id，后续通过该id查询对应结果
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
