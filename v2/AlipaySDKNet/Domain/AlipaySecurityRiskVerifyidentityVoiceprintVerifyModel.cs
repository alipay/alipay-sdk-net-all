using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityVoiceprintVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskVerifyidentityVoiceprintVerifyModel : AopObject
    {
        /// <summary>
        /// base64加密后的语音数据字符串
        /// </summary>
        [XmlElement("base_64_audio_data")]
        public string Base64AudioData { get; set; }

        /// <summary>
        /// 设备唯一id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 流程类型
        /// </summary>
        [XmlElement("flow_data")]
        public string FlowData { get; set; }

        /// <summary>
        /// 长核身会话id
        /// </summary>
        [XmlElement("long_verify_session_id")]
        public string LongVerifySessionId { get; set; }

        /// <summary>
        /// 外部业务id,用于幂等
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 核身会话id，首次校验后返回，关联一次会话
        /// </summary>
        [XmlElement("verify_session_id")]
        public string VerifySessionId { get; set; }

        /// <summary>
        /// 语音数据格式类型
        /// </summary>
        [XmlElement("voice_data_type")]
        public string VoiceDataType { get; set; }

        /// <summary>
        /// 描述语音交互的步骤
        /// </summary>
        [XmlElement("voice_verify_step")]
        public string VoiceVerifyStep { get; set; }
    }
}
