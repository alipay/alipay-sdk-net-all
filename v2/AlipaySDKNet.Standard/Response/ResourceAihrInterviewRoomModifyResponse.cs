using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ResourceAihrInterviewRoomModifyResponse.
    /// </summary>
    public class ResourceAihrInterviewRoomModifyResponse : AopResponse
    {
        /// <summary>
        /// 面试间ID
        /// </summary>
        [XmlElement("ai_interview_id")]
        public string AiInterviewId { get; set; }
    }
}
