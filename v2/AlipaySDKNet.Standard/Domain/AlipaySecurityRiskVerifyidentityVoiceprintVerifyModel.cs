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
        /// 设备名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 流程类型
        /// </summary>
        [XmlElement("flow_data")]
        public string FlowData { get; set; }

        /// <summary>
        /// 长核身会话id，首次调用后返回，如未返回，可忽略
        /// </summary>
        [XmlElement("long_verify_session_id")]
        public string LongVerifySessionId { get; set; }

        /// <summary>
        /// 外部业务id,用于幂等
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 标识业务方接入的校验场景：调用方系统名_业务产品_业务产品节点_业务接入渠道
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

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
        /// 描述语音交互的步骤，具体步骤包含：AROUSE("AROUSE", "唤起")     , PERSISTENT_INTERACTIONS("PERSISTENT_INTERACTIONS", "持续的交互内容")     , SPECIFIC_CONTENT("SPECIFIC_CONTENT", "指定内容朗读验证")     , RECOGNIZE_PAY_MONEY("RECOGNIZE_PAY_MONEY", "识别支付金额")     , PAY_CONFIRM("PAY_CONFIRM", "支付确认")
        /// </summary>
        [XmlElement("voice_verify_step")]
        public string VoiceVerifyStep { get; set; }
    }
}
