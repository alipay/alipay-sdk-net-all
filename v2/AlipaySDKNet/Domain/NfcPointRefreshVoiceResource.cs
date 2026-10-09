using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcPointRefreshVoiceResource Data Structure.
    /// </summary>
    [Serializable]
    public class NfcPointRefreshVoiceResource : AopObject
    {
        /// <summary>
        /// 语音适配的设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 语音对应的图片展示点位
        /// </summary>
        [XmlElement("voice_position")]
        public string VoicePosition { get; set; }

        /// <summary>
        /// 语音文件地址
        /// </summary>
        [XmlElement("voice_url")]
        public string VoiceUrl { get; set; }
    }
}
