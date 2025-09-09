using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiAgentSessionfeedbackSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiAgentSessionfeedbackSubmitModel : AopObject
    {
        /// <summary>
        /// 反馈评价参数
        /// </summary>
        [XmlElement("feedback")]
        public string Feedback { get; set; }

        /// <summary>
        /// 单次会话评分
        /// </summary>
        [XmlElement("satisfaction")]
        public long Satisfaction { get; set; }

        /// <summary>
        /// 场景用户id
        /// </summary>
        [XmlElement("scene_user_id")]
        public string SceneUserId { get; set; }

        /// <summary>
        /// 标识同一次多轮对话的id，sessionId相同表示用户在同一会话中
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
