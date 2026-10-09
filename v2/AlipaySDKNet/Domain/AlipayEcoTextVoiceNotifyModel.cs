using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoTextVoiceNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoTextVoiceNotifyModel : AopObject
    {
        /// <summary>
        /// 语音回调列表
        /// </summary>
        [XmlArray("callbacks")]
        [XmlArrayItem("spi_voice_callback")]
        public List<SpiVoiceCallback> Callbacks { get; set; }
    }
}
