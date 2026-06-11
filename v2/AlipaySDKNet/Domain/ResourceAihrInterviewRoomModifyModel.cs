using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourceAihrInterviewRoomModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ResourceAihrInterviewRoomModifyModel : AopObject
    {
        /// <summary>
        /// 面试间ID
        /// </summary>
        [XmlElement("ai_interview_id")]
        public string AiInterviewId { get; set; }

        /// <summary>
        /// 固定值，对应系统租户
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 面试间过期时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }
    }
}
