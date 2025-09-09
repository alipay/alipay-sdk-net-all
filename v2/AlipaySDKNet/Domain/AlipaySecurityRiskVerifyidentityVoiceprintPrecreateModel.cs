using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityVoiceprintPrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskVerifyidentityVoiceprintPrecreateModel : AopObject
    {
        /// <summary>
        /// 用户朗读后的语音数据base64加密后结果
        /// </summary>
        [XmlElement("base_64_audio_data")]
        public string Base64AudioData { get; set; }

        /// <summary>
        /// 设备唯一id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 注册数据
        /// </summary>
        [XmlElement("register_info")]
        public string RegisterInfo { get; set; }

        /// <summary>
        /// 开通时的唯一token,sdk生成
        /// </summary>
        [XmlElement("register_token")]
        public string RegisterToken { get; set; }

        /// <summary>
        /// 如注册时，外部业务需要指定用户朗读的语音内容，需要传递该文本内容
        /// </summary>
        [XmlElement("voice_text")]
        public string VoiceText { get; set; }
    }
}
