using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityVoiceprintVerifyResponse.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityVoiceprintVerifyResponse : AopResponse
    {
        /// <summary>
        /// 语音识别文本
        /// </summary>
        [XmlElement("asr_content")]
        public string AsrContent { get; set; }

        /// <summary>
        /// 核身长会话ID
        /// </summary>
        [XmlElement("long_verify_session_id")]
        public string LongVerifySessionId { get; set; }

        /// <summary>
        /// 核身渲染信息
        /// </summary>
        [XmlElement("verify_data")]
        public string VerifyData { get; set; }

        /// <summary>
        /// 核身校验是否通过
        /// </summary>
        [XmlElement("verify_pass")]
        public string VerifyPass { get; set; }

        /// <summary>
        /// 核身会话id
        /// </summary>
        [XmlElement("verify_session_id")]
        public string VerifySessionId { get; set; }
    }
}
