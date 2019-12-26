using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceAudioQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备上的语音列表.格式为json字符串. audioId为语音id,playType为播放场景,取值为TRADE或CUSTOM_AUDIO
        /// </summary>
        [XmlElement("audio_list")]
        public string AudioList { get; set; }
    }
}
