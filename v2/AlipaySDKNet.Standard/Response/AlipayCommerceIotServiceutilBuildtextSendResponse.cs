using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotServiceutilBuildtextSendResponse.
    /// </summary>
    public class AlipayCommerceIotServiceutilBuildtextSendResponse : AopResponse
    {
        /// <summary>
        /// 语音文件id
        /// </summary>
        [XmlElement("audio_id")]
        public string AudioId { get; set; }

        /// <summary>
        /// 文件md5
        /// </summary>
        [XmlElement("md_5")]
        public string Md5 { get; set; }

        /// <summary>
        /// 语音文件url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
