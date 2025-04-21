using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmCrmOneaudioQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmCrmOneaudioQueryResponse : AopResponse
    {
        /// <summary>
        /// 通话ID
        /// </summary>
        [XmlElement("acid")]
        public string Acid { get; set; }

        /// <summary>
        /// 机器人通话录音
        /// </summary>
        [XmlElement("ivr_audio")]
        public AudioInfo IvrAudio { get; set; }

        /// <summary>
        /// 人工坐席通话录音
        /// </summary>
        [XmlElement("one_audio")]
        public AudioInfo OneAudio { get; set; }
    }
}
