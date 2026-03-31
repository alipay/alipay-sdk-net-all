using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskGuardrailsAgentDetectResponse.
    /// </summary>
    public class AlipaySecurityRiskGuardrailsAgentDetectResponse : AopResponse
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
        /// 检测数据ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否安全无风险，true: 安全无风险，false: 有风险
        /// </summary>
        [XmlElement("safe")]
        public bool Safe { get; set; }

        /// <summary>
        /// 会话动作
        /// </summary>
        [XmlElement("session_action")]
        public string SessionAction { get; set; }
    }
}
