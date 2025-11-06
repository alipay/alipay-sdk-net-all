using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcVideoconferencetaskQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfrtcVideoconferencetaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 来源ID
        /// </summary>
        [XmlElement("source_id")]
        public long SourceId { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
