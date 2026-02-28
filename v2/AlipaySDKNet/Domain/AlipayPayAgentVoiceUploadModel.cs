using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAgentVoiceUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAgentVoiceUploadModel : AopObject
    {
        /// <summary>
        /// 首次调用后返回，关联一次会话（存在多次语音上传交互时，后续带上该字段可以关联本次语音上传的会话上下文）
        /// </summary>
        [XmlElement("agent_voice_sid")]
        public string AgentVoiceSid { get; set; }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// base64加密后的语音数据字符串
        /// </summary>
        [XmlElement("base_64_audio_data")]
        public string Base64AudioData { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 业务场景，由支付宝分配，用于调用管控和定制化处理
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 语音数据格式类型
        /// </summary>
        [XmlElement("voice_data_type")]
        public string VoiceDataType { get; set; }

        /// <summary>
        /// 描述语音交互的步骤，具体步骤包含： 唤起（AROUSE） 识别支付金额（RECOGNIZE_PAY_MONEY） 确认支付（PAY_CONFIRM）
        /// </summary>
        [XmlElement("voice_verify_step")]
        public string VoiceVerifyStep { get; set; }
    }
}
