using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ResourceAihrInterviewRoomCreateResponse.
    /// </summary>
    public class ResourceAihrInterviewRoomCreateResponse : AopResponse
    {
        /// <summary>
        /// 面试间ID
        /// </summary>
        [XmlElement("ai_interview_id")]
        public string AiInterviewId { get; set; }

        /// <summary>
        /// 面试链接
        /// </summary>
        [XmlElement("ai_interview_url")]
        public string AiInterviewUrl { get; set; }

        /// <summary>
        /// 面试间过期时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }
    }
}
