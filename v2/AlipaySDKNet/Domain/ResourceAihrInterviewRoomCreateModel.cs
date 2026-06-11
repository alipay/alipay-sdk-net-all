using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourceAihrInterviewRoomCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ResourceAihrInterviewRoomCreateModel : AopObject
    {
        /// <summary>
        /// AI面试流程编码
        /// </summary>
        [XmlElement("ai_interview_code")]
        public string AiInterviewCode { get; set; }

        /// <summary>
        /// 对应系统租户，用于校验是否和APPID对应租户一致
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 选填，由调用方提供，同一租户+环境下幂等键唯一
        /// </summary>
        [XmlElement("idempotent_key")]
        public string IdempotentKey { get; set; }

        /// <summary>
        /// 岗位信息
        /// </summary>
        [XmlElement("job_info")]
        public OpenapiInterviewJobInfoDTO JobInfo { get; set; }

        /// <summary>
        /// 候选人信息
        /// </summary>
        [XmlElement("user_info")]
        public OpenapiInterviewUserInfoDTO UserInfo { get; set; }
    }
}
