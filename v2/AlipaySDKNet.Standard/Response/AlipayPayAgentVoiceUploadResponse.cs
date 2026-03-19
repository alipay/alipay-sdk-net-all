using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAgentVoiceUploadResponse.
    /// </summary>
    public class AlipayPayAgentVoiceUploadResponse : AopResponse
    {
        /// <summary>
        /// 唯一标识一次语音上传的会话，当商户与支付宝有多次语音上传交互时，首次会新生成，后续带上该字段可以关联本次语音上传的会话上下文
        /// </summary>
        [XmlElement("agent_voice_sid")]
        public string AgentVoiceSid { get; set; }

        /// <summary>
        /// 流式语音初始化信息，用于后续调用支付SDK做流式建连
        /// </summary>
        [XmlElement("stream_voice_init_info")]
        public string StreamVoiceInitInfo { get; set; }
    }
}
