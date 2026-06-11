using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenapiInterviewProcessItem Data Structure.
    /// </summary>
    [Serializable]
    public class OpenapiInterviewProcessItem : AopObject
    {
        /// <summary>
        /// AI面试流程编码
        /// </summary>
        [XmlElement("ai_interview_code")]
        public string AiInterviewCode { get; set; }

        /// <summary>
        /// AI面试流程名称
        /// </summary>
        [XmlElement("ai_interview_name")]
        public string AiInterviewName { get; set; }
    }
}
