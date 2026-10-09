using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiAgentAnswerfeedbackSubmitResponse.
    /// </summary>
    public class AnttechAiAgentAnswerfeedbackSubmitResponse : AopResponse
    {
        /// <summary>
        /// 单次对话反馈结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
