using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioCreateResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceAudioCreateResponse : AopResponse
    {
        /// <summary>
        /// 语音id
        /// </summary>
        [XmlElement("audio_id")]
        public string AudioId { get; set; }

        /// <summary>
        /// 语音文件的地址.用户可以通过此地址试听合成的语音
        /// </summary>
        [XmlElement("audio_url")]
        public string AudioUrl { get; set; }
    }
}
