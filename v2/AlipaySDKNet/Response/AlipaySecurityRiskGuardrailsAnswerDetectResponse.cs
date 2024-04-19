using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskGuardrailsAnswerDetectResponse.
    /// </summary>
    public class AlipaySecurityRiskGuardrailsAnswerDetectResponse : AopResponse
    {
        /// <summary>
        /// 安全动作
        /// </summary>
        [XmlElement("action_code")]
        public string ActionCode { get; set; }

        /// <summary>
        /// 安全动作相关文案
        /// </summary>
        [XmlElement("action_msg")]
        public string ActionMsg { get; set; }

        /// <summary>
        /// 风险识别标签内容
        /// </summary>
        [XmlArray("detect_check_labels")]
        [XmlArrayItem("string")]
        public List<string> DetectCheckLabels { get; set; }

        /// <summary>
        /// 检测数据ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否安全无风险
        /// </summary>
        [XmlElement("safe")]
        public bool Safe { get; set; }

        /// <summary>
        /// 会话动作
        /// </summary>
        [XmlElement("session_action")]
        public string SessionAction { get; set; }

        /// <summary>
        /// 处置建议：pass、review、block
        /// </summary>
        [XmlElement("suggestion")]
        public string Suggestion { get; set; }
    }
}
