using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJobinterviewInterviewInitializeResponse.
    /// </summary>
    public class AlipayEbppJobinterviewInterviewInitializeResponse : AopResponse
    {
        /// <summary>
        /// 候选人本次面试唯一标识,后续接口均需透传
        /// </summary>
        [XmlElement("candidate_id")]
        public string CandidateId { get; set; }

        /// <summary>
        /// 候选人进入面试间的专属链接,勿修改参数
        /// </summary>
        [XmlElement("interview_url")]
        public string InterviewUrl { get; set; }

        /// <summary>
        /// 面试间有效的截止时间,格式yyyy-MM-dd HH:mm:ss。过期后无法进入面试
        /// </summary>
        [XmlElement("room_expire_time")]
        public string RoomExpireTime { get; set; }

        /// <summary>
        /// 候选人当前面试状态,用于识别可执行的后续操作
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
