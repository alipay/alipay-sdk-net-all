using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiAgentSessionfeedbackSubmitResponse.
    /// </summary>
    public class AnttechAiAgentSessionfeedbackSubmitResponse : AopResponse
    {
        /// <summary>
        /// 单次对话反馈结果，执行结果成功和失败
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
